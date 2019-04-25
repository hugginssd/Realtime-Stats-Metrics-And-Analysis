using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Realtime_Stats_Metrics_And_Analysis.UI
{
    public partial class UserLogin : UserControl
    {
        public UserLogin()
        {
            InitializeComponent();
        }
        FrmMain frmMain = new FrmMain();
        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            frmMain.Hide();
        }
    }
}
