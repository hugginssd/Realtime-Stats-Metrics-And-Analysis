using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Realtime_Stats_Metrics_And_Analysis.DAL;
using Realtime_Stats_Metrics_And_Analysis.BLL;

namespace Realtime_Stats_Metrics_And_Analysis.UI
{
    public partial class UserSystemUsers : UserControl
    {
        public UserSystemUsers()
        {
            InitializeComponent();
        }
        UserBLL ubll = new UserBLL();
        UserDAL udal = new UserDAL();
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                ubll.FirstName = txtFirstname.Text;
                ubll.LastName = txtLastname.Text;
                ubll.Password = txtPassword.Text;
                ubll.UserName = txtUsername.Text;
                ubll.UserType = "User";
                bool IsSuccess = udal.Insert(ubll);
                if (IsSuccess)
                {
                    MessageBox.Show("Successfully saved");
                }
                else
                {
                    MessageBox.Show("Failed to initiate a record");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"UI error");
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                DataTable dt = new DataTable();
                dt = udal.Select(txtSearch.Text);
                dataGridView1.DataSource = dt;
            }

        }
    }
}
