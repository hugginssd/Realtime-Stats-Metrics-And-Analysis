using Realtime_Stats_Metrics_And_Analysis.BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Realtime_Stats_Metrics_And_Analysis.DAL
{
    class TransactionDetailsDAL
    {
        Connection connect = new Connection();
        public bool InsertTransactionDetail(TransactionDetailBLL td)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(this.connect.connection);
            try
            {
                string sql = "INSERT INTO [dbo].[tbltransactiondetail]" +
                                                   "([productid]" +
                                                   ",[rate]" +
                                                   ",[qty]" +
                                                   ",[total]" +
                                                   ",[deacustid]" +
                                                   ",[addeddate]" +
                                                   ",[addedby])" +
                                             "VALUES" +
                                                   "(@productid," +
                                                   "@rate," +
                                                   "@qty," +
                                                   "@total," +
                                                   "@deacustid," +
                                                   "@addeddate," +
                                                   "@addedby)";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@productid", td.ID);
                cmd.Parameters.AddWithValue("@rate", td.Rate);
                cmd.Parameters.AddWithValue("@qty", td.Qty);
                cmd.Parameters.AddWithValue("@total", td.GrandTotal);
                cmd.Parameters.AddWithValue("@deacustid", td.DeaCustID);
                cmd.Parameters.AddWithValue("@addeddate", td.AddedDate);
                cmd.Parameters.AddWithValue("@addedby", td.AddedBy);

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

    }
}
