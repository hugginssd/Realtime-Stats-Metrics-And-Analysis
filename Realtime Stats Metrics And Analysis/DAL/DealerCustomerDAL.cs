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
    class DealerCustomerDAL
    {
        Connection connect = new Connection();
        public DataTable Selectt()
        {
            SqlConnection con = new SqlConnection(this.connect.connection);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT *  FROM [dbo].[tbldeacust]";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                con.Open();
                da.Fill(dt);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public bool Insert(DealerCustomerBLL bi) {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(this.connect.connection);

            try
            {
                string sql = "INSERT INTO [dbo].[tbldeacust]" +
                                       "([type]" +
                                       ",[name]" +
                                       ",[email]" +
                                       ",[contact]" +
                                       ",[address]" +
                                       ",[addeddate]" +
                                       ",[addedby])" +
                                 "VALUES" +
                                       "(@type," +
                                       "@name," +
                                       "@email," +
                                       "@contact," +
                                       "@address," +
                                       "@addeddate," +
                                       "@addedby)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@type", bi.Type);
                cmd.Parameters.AddWithValue("@name", bi.Name);
                cmd.Parameters.AddWithValue("@email", bi.Email);
                cmd.Parameters.AddWithValue("@contact", bi.Contact);
                cmd.Parameters.AddWithValue("@address", bi.Address);
                cmd.Parameters.AddWithValue("@addeddate", bi.AddedDate);
                cmd.Parameters.AddWithValue("@addedby", bi.AddedBy);
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
            finally {
                con.Close();
            }
            return isSuccess;
        }

        public bool Update(DealerCustomerBLL bu) {
            SqlConnection con = new SqlConnection(this.connect.connection);
            bool isSuccess = false;
            try
            {
                string sql = "UPDATE [dbo].[tbldeacust]" +
                                       "SET[type] = @type," +
                                           "[name] = @name," +
                                           "[email] = @email," +
                                           "[contact] = @contact," +
                                           "[address] = @address," +
                                           "[addeddate] = @addeddate," +
                                           "[addedby] = @addedby," +
                                     "WHERE id = @id";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@type", bu.Type);
                cmd.Parameters.AddWithValue("@name", bu.Name);
                cmd.Parameters.AddWithValue("@email", bu.Email);
                cmd.Parameters.AddWithValue("@contact", bu.Contact);
                cmd.Parameters.AddWithValue("@address", bu.Address);
                cmd.Parameters.AddWithValue("@addeddate", bu.AddedDate);
                cmd.Parameters.AddWithValue("@addedby", bu.AddedBy);
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

        public bool Delete(DealerCustomerBLL bd) {
            SqlConnection con = new SqlConnection(this.connect.connection);
            bool isSuccess = false;
            try
            {
                string sql = "DELETE FROM tbldeacust WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", bd.ID);
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
        public DataTable Search(string keywords) {
            SqlConnection con = new SqlConnection(this.connect.connection);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM tbldeacust WHERE id LIKE '%" + keywords + "%' OR name LIKE '%" + keywords + "%' OR  type LIKE '%" + keywords + "%'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                con.Open();
                da.Fill(dt);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
            finally {
                con.Close();
            }

            return dt;
        }

        public DealerCustomerBLL SearchDealerCustomerForTransaction(string keywords) {
            DealerCustomerBLL dc = new DealerCustomerBLL();
            SqlConnection con = new SqlConnection(this.connect.connection);

            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT [id]" +
                              ",[type]" +
                              ",[name]" +
                              ",[email]" +
                              ",[contact]" +
                              ",[address]" +
                              ",[addeddate]" +
                              ",[addedby]" +
                              "FROM[dbo].[tbldeacust]" +
                              "WHERE id LIKE '%" + keywords + "%' OR name LIKE '%" + keywords + "%'";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                con.Open();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dc.Name = dt.Rows[0]["name"].ToString();
                    dc.Email = dt.Rows[0]["email"].ToString();
                    dc.Contact = dt.Rows[0]["contact"].ToString();
                    dc.Address = dt.Rows[0]["address"].ToString();
                }
            }
            catch (Exception ex) {

                MessageBox.Show(ex.ToString());
            }
            finally {
                con.Close();
            }

            return dc;
        }

        public DealerCustomerBLL GetDeaCustIFromName(string name)
        {
            DealerCustomerBLL dc = new DealerCustomerBLL();
            SqlConnection con = new SqlConnection(this.connect.connection);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT [id]" +
                            ",[type]" +
                            ",[name]" +
                            ",[email]" +
                            ",[contact]" +
                            ",[address]" +
                            ",[addeddate]" +
                            ",[addedby]" +
                            "FROM[dbo].[tbldeacust]" +
                            "WHERE name " + name;


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return dc;
        }
        }
}
