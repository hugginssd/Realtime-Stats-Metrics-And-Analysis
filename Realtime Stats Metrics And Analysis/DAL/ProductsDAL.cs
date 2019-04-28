using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realtime_Stats_Metrics_And_Analysis.DAL
{
    class ProductsDAL
    {
        Public Function Selectt() As DataTable
        Static con As New SqlConnection(constring)
        Dim dt = New DataTable
        Try
            Dim sql = "SELECT * FROM tblproducts"
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

    Public Function Insert(bi As productsBLL) As Boolean
        Dim isSuccess = False
        Static con As New SqlConnection(constring)

        Try
            Dim sql = "INSERT INTO tblproducts(name,category,description,rate,qty,addeddate,addedby)" +
                "VALUES(@name,@category,@description,@rate,@qty,@addeddate,@addedby)"
            Dim cmd = New SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@name", bi.Name)
            cmd.Parameters.AddWithValue("@category", bi.Category)
            cmd.Parameters.AddWithValue("@description", bi.Description)
            cmd.Parameters.AddWithValue("@rate", bi.Rate)
            cmd.Parameters.AddWithValue("@qty", bi.Qty)
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

    Public Function Update(bu As productsBLL) As Boolean
        Static con As New SqlConnection(constring)
        Dim isSuccess = False
        Try
            Dim sql = "UPDATE tblproducts SET name=@name,category=@category,description=@description,rate=@rate,qty=@qty,addeddate=@addeddate,addedby=@addedby WHERE id=@id)"
            Dim cmd = New SqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@name", bu.Name)
            cmd.Parameters.AddWithValue("@category", bu.Category)
            cmd.Parameters.AddWithValue("@description", bu.Description)
            cmd.Parameters.AddWithValue("@rate", bu.Rate)
            cmd.Parameters.AddWithValue("@qty", bu.Qty)
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

    Public Function Delete(bd As productsBLL) As Boolean
        Static con As New SqlConnection(constring)
        Dim isSuccess = False
        Try
            Dim sql = "DELETE FROM tblproducts WHERE id=@id"
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
            Dim sql = "SELECT * FROM tblproducts WHERE id LIKE '%" + keywords + "%' OR name LIKE '%" + keywords + "%' OR  category LIKE '%" + keywords + "%'"
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

    Public Function GetProductsForTransaction(keyword As String) As productsBLL
        Dim pb As New productsBLL

        Dim con As New SqlConnection(constring)
        Dim dt = New DataTable
        Try
            Dim sql = "SELECT [id]
                              ,[name]
                              ,[category]
                              ,[description]
                              ,[rate]
                              ,[qty]
                              ,[addeddate]
                              ,[addedby]
                          FROM[dbo].[tblproducts]
        WHERE id LIKE '%" + keyword + "%' OR name LIKE '%" + keyword + "%' "
            Dim cmd = New SqlCommand(sql, con)
            Dim da = New SqlDataAdapter(cmd)
            con.Open()
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                pb.Name = dt.Rows(0)("name").ToString
                pb.Rate = Decimal.Parse(dt.Rows(0)("rate").ToString)
                pb.Qty = Decimal.Parse(dt.Rows(0)("qty").ToString)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally

            con.Close()
        End Try

        Return pb

    End Function

    }
}
