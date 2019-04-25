using Realtime_Stats_Metrics_And_Analysis.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Realtime_Stats_Metrics_And_Analysis.DAL
{
    class UserDAL
    {
        Connection con = new Connection();
        public bool Insert(UserBLL bll)
        {
            bool IsSuccess = false;
            SqlConnection conn = new SqlConnection(this.con.connection);
            string sql = "INSERT INTO[dbo].[Users]" +
                                  "([FIRSTNAME]" +
                                  ",[LASTNAME]" +
                                  ",[USERNAME]" +
                                  ",[PASSWORD])" +
                            "VALUES" +
                                  "(@FIRSTNAME" +
                                  ",@LASTNAME" +
                                  ",@USERNAME" +
                                  ",@PASSWORD)";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@FIRSTNAME", bll.FirstName);
                cmd.Parameters.AddWithValue("@LASTNAME", bll.LastName);
                cmd.Parameters.AddWithValue("@USERNAME", bll.UserName);
                cmd.Parameters.AddWithValue("@PASSWORD", bll.Password);
                conn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    IsSuccess = true;
                }
                else
                {
                    IsSuccess = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Data Access Error", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
            finally
            {
                conn.Close();
            }
            return IsSuccess;
        }
        public DataTable Select(string keywords)
        {
            DataTable dt = null;
            SqlConnection conn = new SqlConnection(this.con.connection);
            string sql = "SELECT [USERID]" +
                              ",[FIRSTNAME]" +
                              ",[LASTNAME]" +
                              ",[USERNAME]" +
                              ",[PASSWORD]" +
                          "FROM[dbo].[Users]" +
                          " WHERE [USERNAME] LIKE '%" + keywords + "%' OR [LASTNAME] LIKE '%" + keywords + "%' OR [FIRSTNAME] LIKE '%" + keywords + "%'  ";
            try
            {
                SqlDataAdapter da;
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                dt = new DataTable();
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Data Access Error", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
            finally
            {
                conn.Close();
            }

            return dt;

        }
        public bool Delete(UserBLL bll)
        {
            bool IsSuccess = false;
            SqlConnection conn = new SqlConnection(this.con.connection);
            string sql = "DELETE FROM [dbo].[Users]" +
                                    "WHERE [USERID]= @USERID ";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@USERID", bll.UserID);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    IsSuccess = true;
                }
                else
                {
                    IsSuccess = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Data Access Error", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
            finally
            {
                conn.Close();
            }

            return IsSuccess;
        }
        public bool Update(UserBLL bll)
        {
            bool IsSuccess = false;
            SqlConnection conn = new SqlConnection(this.con.connection);
            string sql = "UPDATE [dbo].[Users]"+
                               "SET[FIRSTNAME] = @FIRSTNAME"+
                                  ",[LASTNAME] = @LASTNAME"+
                                  ",[USERNAME] = @USERNAME"+
                                  ",[PASSWORD] = @PASSWORD"+
                             "WHERE [USERNAME] = @USERNAME";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@USERNAME", bll.UserName);
                conn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    IsSuccess = true;
                }
                else
                {
                    IsSuccess = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Data Access Error", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
            finally
            {
                conn.Close();
            }

            return IsSuccess;
        }
        public bool Search(UserBLL bll)
        {
            bool IsSuccess = false;
            SqlConnection conn = new SqlConnection(this.con.connection);
            string sql = "SELECT [USERID]"+
                              ",[FIRSTNAME]"+
                              ",[LASTNAME]"+
                              ",[USERNAME]"+
                              ",[PASSWORD]"+
                              "FROM[dbo].[Users]"+
                              "WHERE [USERNAME]=@USERNAME AND [PASSWORD] =@PASSWORD";
            try
            {

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = null;
                cmd.Parameters.AddWithValue("@USERNAME", bll.UserName);
                cmd.Parameters.AddWithValue("@PASSWORD", bll.Password);
                conn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    IsSuccess = true;
                }
                else
                {
                    IsSuccess = false;
                }

                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Data Access Error", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
            finally
            {
                conn.Close();
            }
            return IsSuccess;
        }
        public bool SignInAdmin(UserBLL bll)
        {   
            bool IsSuccess = false;
            SqlConnection conn = new SqlConnection(this.con.connection);
            string sql = "SELECT [USERID]" +
                              ",[FIRSTNAME]" +
                              ",[LASTNAME]" +
                              ",[USERNAME]" +
                              ",[PASSWORD]" +
                              "FROM[dbo].[Users]" +
                              "WHERE [PASSWORD] =@PASSWORD";
            try
            {

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = null;
                cmd.Parameters.AddWithValue("@PASSWORD", bll.Password);
                conn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    IsSuccess = true;
                }
                else
                {
                    IsSuccess = false;
                }

                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Data Access Error", MessageBoxButtons.OK, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
            finally
            {
                conn.Close();
            }
            return IsSuccess;
        }
    }
}
