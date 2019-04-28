using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Realtime_Stats_Metrics_And_Analysis.BLL;
using Realtime_Stats_Metrics_And_Analysis.DAL;

namespace Realtime_Stats_Metrics_And_Analysis.UI
{
    public partial class UserLogin : UserControl
    {
        public UserLogin()
        {
            InitializeComponent();
        }
        FrmMain frmMain = new FrmMain();
        UserBLL ubll = new UserBLL();
        UserDAL ud = new UserDAL();
        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            ubll.UserName = txtUsername.Text;
          //  ubll.Password = txtPassword.Text;

            bool success = ud.SignInAdmin(ubll);
            if (success) {
                switch (ubll.UserType)
                {
                    case "Admin":
                        Form1 form = new Form1();
                        form.Show();
                        break;
                    case "User":
                        FrmMain frmMain = new FrmMain();
                        frmMain.Show();
                        break;
                    default:
                        MessageBox.Show("Login failed try again");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Invalid login details");
            }
        }
    }
}
