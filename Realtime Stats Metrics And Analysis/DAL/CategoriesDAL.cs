using Realtime_Stats_Metrics_And_Analysis.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Realtime_Stats_Metrics_And_Analysis.DAL
{
    class CategoriesDAL
    {
        Connection connect = new Connection();
        public DataTable Selectt()
        {
            SqlConnection con = new SqlConnection(this.connect.connection);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM tblcategories";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                con.Open();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();

            }
            return dt;
        }

        public bool Insert(CategoriesBLL b)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(this.connect.connection);
            try
            {
                string sql = "INSERT INTO [dbo].[tblcategories]" +
                                               "([title]" +
                                               ",[description]" +
                                               ",[addeddate]" +
                                              ",[addedby])" +
                                         "VALUES" +
                                               "(@title," +
                                               " @description," +
                                                "@addeddate," +
                                                "@addedby)";
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@title", b.Title);
                cmd.Parameters.AddWithValue("@description", b.Description);
                cmd.Parameters.AddWithValue("@addeddate", b.AddedDate);
                cmd.Parameters.AddWithValue("@addedby", b.AddedBy);
                con.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return isSuccess;
        }

        public bool Update(CategoriesBLL b)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(this.connect.connection);
            try
            {
                string sql = "UPDATE [dbo].[tblcategories]" +
                                   "SET[title] = @title," +
                                   "[description] = @description," +
                                   "[addeddate] = @addeddate," +
                                   "[addedby] = @addedby" +
                                   "WHERE id =@id";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@title", b.Title);
                cmd.Parameters.AddWithValue("@description", b.Description);
                cmd.Parameters.AddWithValue("@addeddate", b.AddedDate);
                cmd.Parameters.AddWithValue("@addedby", b.AddedBy);
                con.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }

        public bool Delete(CategoriesBLL b) {

        bool isSuccess = false;

        SqlConnection con = new SqlConnection(this.connect.connection);

            try
            {
                string sql = "DELETE FROM [dbo].[tblcategories]" +
                                 " WHERE id = @id";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", b.ID);
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }

        return isSuccess;
   }

        public DataTable Search(string keywords)
    {
        SqlConnection con = new SqlConnection(this.connect.connection);
        DataTable dt = new DataTable();
        try{
            string sql = "SELECT * FROM tblcategories WHERE id LIKE '%" + keywords + "%' OR title LIKE '%" + keywords + "%' OR  description LIKE '%" + keywords + "%'";
           SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Open();
            da.Fill(dt);
    }
        catch(Exception ex){
            MessageBox.Show(ex.ToString());
        }finally{
            con.Close();
        }

        return dt;
    }
    }
}
