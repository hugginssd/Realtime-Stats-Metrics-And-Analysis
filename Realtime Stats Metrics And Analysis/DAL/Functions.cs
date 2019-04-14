using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Realtime_Stats_Metrics_And_Analysis.DAL
{
    class Functions
    {
        //fucollection of project functions 
        public string connection = ConfigurationManager.ConnectionStrings["realtime"].ToString();
        public int _nextId(string table)
        {
            SqlDataAdapter da = null;
            DataTable dt = null;
            int MAX_ID = 0;
            SqlConnection con = new SqlConnection(connection);
            string sql = "SELECT MAX(ID) + 1 FROM " + table;
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {

                con.Open();
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MAX_ID = Convert.ToInt32(dt.Rows[0][0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Function Error");
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }

            return MAX_ID;
        }
    }
}
