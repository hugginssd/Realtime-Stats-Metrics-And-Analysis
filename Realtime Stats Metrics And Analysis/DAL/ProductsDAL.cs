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
    class ProductsDAL
    {
        Connection connect = new Connection();
        public DataTable Selectt() {
            SqlConnection con = new SqlConnection(this.connect.connection);
            DataTable dt = new DataTable();
            try {
                string sql = "SELECT * FROM tblproducts";
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

        public bool Insert(ProductsBLL bi) {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(this.connect.connection);

            try
            {
                string sql = "INSERT INTO tblproducts(name,category,description,rate,qty,addeddate,addedby)" +
                    "VALUES(@name,@category,@description,@rate,@qty,@addeddate,@addedby)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@name", bi.Name);
                cmd.Parameters.AddWithValue("@category", bi.Category);
                cmd.Parameters.AddWithValue("@description", bi.Description);
                cmd.Parameters.AddWithValue("@rate", bi.Rate);
                cmd.Parameters.AddWithValue("@qty", bi.Qty);
                cmd.Parameters.AddWithValue("@addeddate", bi.AddedDate);
                cmd.Parameters.AddWithValue("@addedby", bi.AddedBy);
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0) {
                    isSuccess = true;
                } else {
                    isSuccess = false;
                }


            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
            finally {
                con.Close();


            }
            return isSuccess;
        }

        public bool Update(ProductsBLL bu) {
            SqlConnection con = new SqlConnection(this.connect.connection);
            bool isSuccess = false;
            try
            {
                string sql = "UPDATE tblproducts SET name=@name,category=@category,description=@description,rate=@rate,qty=@qty,addeddate=@addeddate,addedby=@addedby WHERE id=@id)";
            SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@name", bu.Name);
                cmd.Parameters.AddWithValue("@category", bu.Category);
                cmd.Parameters.AddWithValue("@description", bu.Description);
                cmd.Parameters.AddWithValue("@rate", bu.Rate);
                cmd.Parameters.AddWithValue("@qty", bu.Qty);
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

            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
            finally {
                con.Close();
            }
            return isSuccess;
        }

        public bool Delete(ProductsBLL bd) {
            SqlConnection con = new SqlConnection(this.connect.connection);
            bool isSuccess = false;
            try
            {
                string sql = "DELETE FROM tblproducts WHERE id=@id";
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
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
            finally {
                con.Close();
            }

            return isSuccess;
        }

        public DataTable Search(string keywords) {
            SqlConnection con = new SqlConnection(this.connect.connection);
            DataTable dt = new DataTable();
            try {
                string sql = "SELECT * FROM tblproducts WHERE id LIKE '%" + keywords + "%' OR name LIKE '%" + keywords + "%' OR  category LIKE '%" + keywords + "%'";
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

        public DataTable GetProductsForTransaction(string keyword){
            ProductsBLL pb = new ProductsBLL();

        SqlConnection con = new SqlConnection(this.connect.connection);
             DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT [id]" +
                             ",[name]" +
                             ",[category]" +
                             ",[description]" +
                             ",[rate]" +
                             ",[qty]" +
                             ",[addeddate]" +
                             ",[addedby]" +
                             "FROM[dbo].[tblproducts]" +
                             "WHERE id LIKE '%" + keyword + "%' OR name LIKE '%" + keyword + "%' ";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                con.Open();
                da.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    pb.Name = dt.Rows[0]["name"].ToString();
                    pb.Rate = Decimal.Parse(dt.Rows[0]["rate"].ToString());
                    pb.Qty = (int)Decimal.Parse(dt.Rows[0]["qty"].ToString());
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

        return dt;


   }
     
    }
}
