using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realtime_Stats_Metrics_And_Analysis.DAL
{
    class DealerCustomerDAL
    {
        Public Function Selectt() As DataTable
        Static con As New SqlConnection(constring)
        Dim dt = New DataTable
        Try
            Dim sql = "SELECT *  FROM [dbo].[tbldeacust]"
            Dim cmd = New SqlCommand(sql, con)
            Dim da = New SqlDataAdapter(cmd)
            con.Open()
            da.Fill(dt)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        Finally
            con.Close()
        End Try



        Return dt
    End Function

    Public Function Insert(bi As dealerCustomerBLL) As Boolean
        Dim isSuccess = False
        Static con As New SqlConnection(constring)

        Try
            Dim sql = "INSERT INTO [dbo].[tbldeacust]
                                   ([type]
                                   ,[name]
                                   ,[email]
                                   ,[contact]
                                   ,[address]
                                   ,[addeddate]
                                   ,[addedby])
                             VALUES
                                   (@type,
                                    @name,
                                    @email,
                                    @contact,
                                    @address,
                                    @addeddate,
                                    @addedby)"
            Dim cmd = New SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@type", bi.Type)
            cmd.Parameters.AddWithValue("@name", bi.Name)
            cmd.Parameters.AddWithValue("@email", bi.Email)
            cmd.Parameters.AddWithValue("@contact", bi.Contact)
            cmd.Parameters.AddWithValue("@address", bi.Address)
            cmd.Parameters.AddWithValue("@addeddate", bi.Addeddate)
            cmd.Parameters.AddWithValue("@addedby", bi.Addedby)
            con.Open()
            Dim rows = cmd.ExecuteNonQuery
            If rows > 0 Then
                isSuccess = True
            Else
                isSuccess = False
            End If



        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()


        End Try





        Return isSuccess
    End Function

    Public Function Update(bu As dealerCustomerBLL) As Boolean
        Static con As New SqlConnection(constring)
        Dim isSuccess = False
        Try
            Dim sql = "UPDATE [dbo].[tbldeacust]
                                   SET[type] = @type,
                                       [name] = @name,
                                       [email] = @email,
                                       [contact] = @contact,
                                       [address] = @address,
                                       [addeddate] = @addeddate,
                                       [addedby] = @addedby,
                                 WHERE id = @id"
            Dim cmd = New SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@type", bu.Type)
            cmd.Parameters.AddWithValue("@name", bu.Name)
            cmd.Parameters.AddWithValue("@email", bu.Email)
            cmd.Parameters.AddWithValue("@contact", bu.Contact)
            cmd.Parameters.AddWithValue("@address", bu.Address)
            cmd.Parameters.AddWithValue("@addeddate", bu.Addeddate)
            cmd.Parameters.AddWithValue("@addedby", bu.Addedby)
            con.Open()
            Dim rows = cmd.ExecuteNonQuery()
            If rows > 0 Then
                isSuccess = True
            Else
                isSuccess = False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        Finally
            con.Close()
        End Try
        Return isSuccess
    End Function

    Public Function Delete(bd As dealerCustomerBLL) As Boolean
        Static con As New SqlConnection(constring)
        Dim isSuccess = False
        Try
            Dim sql = "DELETE FROM tbldeacust WHERE id=@id"
            Dim cmd = New SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@id", bd.Id)
            con.Open()
            Dim rows = cmd.ExecuteNonQuery
            If rows > 0 Then
                isSuccess = True
            Else
                isSuccess = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
        End Try


        Return isSuccess
    End Function

    Public Function Search(ByVal keywords As String) As DataTable
        Static con As New SqlConnection(constring)
        Dim dt = New DataTable
        Try
            Dim sql = "SELECT * FROM tbldeacust WHERE id LIKE '%" + keywords + "%' OR name LIKE '%" + keywords + "%' OR  type LIKE '%" + keywords + "%'"
            Dim cmd = New SqlCommand(sql, con)
            Dim da = New SqlDataAdapter(cmd)
            con.Open()
            da.Fill(dt)

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
        End Try

        Return dt
    End Function

    Public Function SearchDealerCustomerForTransaction(keywords As String) As dealerCustomerBLL
        Dim dc As New dealerCustomerBLL
        Static con As New SqlConnection(constring)

        Dim dt As New DataTable
        Try
            Dim sql = "SELECT [id]
                              ,[type]
                              ,[name]
                              ,[email]
                              ,[contact]
                              ,[address]
                              ,[addeddate]
                              ,[addedby]
                          FROM[dbo].[tbldeacust]
        WHERE id LIKE '%" + keywords + "%' OR name LIKE '%" + keywords + "%'"
            Dim da = New SqlDataAdapter(sql, con)
            con.Open()
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                dc.Name = dt.Rows(0)("name").ToString
                dc.Email = dt.Rows(0)("email").ToString
                dc.Contact = dt.Rows(0)("contact").ToString
                dc.Address = dt.Rows(0)("address").ToString
            End If

        Catch ex As Exception

            MessageBox.Show(ex.ToString)
        Finally
            con.Close()
        End Try

        Return dc

    End Function

    Public Function GetDeaCustIFromName(name As String) As dealerCustomerBLL
        Dim dc As New dealerCustomerBLL
        Static con As New SqlConnection(constring)
        Dim dt = New DataTable
        Try
            Dim sql = "SELECT [id]
                            ,[type]
                            ,[name]
                            ,[email]
                            ,[contact]
                            ,[address]
                            ,[addeddate]
                            ,[addedby]
                        FROM[dbo].[tbldeacust]
        WHERE name " + name



        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        Finally
            con.Close()
        End Try




        Return dc
    End Function
    }
}
