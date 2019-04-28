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
    class TransactionDAL
    {
        Connection connect = new Connection();
        public bool InsertTransaction(TransactionDetailBLL t, int transactionsId)
        {
            bool isSuccess = false;
            transactionsId = -1;
            SqlConnection con = new SqlConnection(this.connect.connection);
            try
            {
                string sql = "INSERT INTO [dbo].[tbltransactions]" +
                                                   "([type]" +
                                                   ",[deacustid]" +
                                                   ",[grandtotal]" +
                                                  ",[transactiondate]" +
                                                   ",[tax]" +
                                                   ",[discount]" +
                                                   ",[addedby])" +
                                             "VALUES" +
                                                   "(@type," +
                                                   "@deacustid," +
                                                   "@grandtotal," +
                                                   "@transactiondate," +
                                                   "@tax," +
                                                   "@discount," +
                                                   "@addedby)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@type", t.Type);
                cmd.Parameters.AddWithValue("@deacustid", t.DeaCustId);
                cmd.Parameters.AddWithValue("@grandtotal", t.GrandTotal);
                cmd.Parameters.AddWithValue("@transactiondate", t.TransactionDate);
                cmd.Parameters.AddWithValue("@tax", t.Tax);
                cmd.Parameters.AddWithValue("@discount", t.Discount);
                cmd.Parameters.AddWithValue("@addedby", t.Addedby);
                con.Open();

                object o = cmd.ExecuteScalar();

                if (o == null)
                {
                    transactionsId = Convert.ToInt32(o.ToString());
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
