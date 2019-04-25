using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Realtime_Stats_Metrics_And_Analysis.UI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private int i = 1;
        private void BtnAdministration_Click(object sender, EventArgs e)
        {
            pnlSidePanel.Location = new Point(0, 122);
            pnlSidePanel.BringToFront();
            i = i + 1;
            if (i%2==0)
            {
                BtnNewDealersCustomers.Visible = true;
                BtnPurchasesSales.Visible = true;
                BtnNewSystemUsers.Visible = false;
                BtnManageSystemUsers.Visible = false;
                BtnCustomers.Visible = false;
            }
            else
            {
                BtnNewDealersCustomers.Visible = false;
                BtnPurchasesSales.Visible = false;
                BtnNewSystemUsers.Visible = false;
                BtnManageSystemUsers.Visible = false;
                BtnCustomers.Visible = true;
            }
        }

        private void BtnNewDealersCustomers_Click(object sender, EventArgs e)
        {
            userDealerCustomer.Visible = true;
            userDealerCustomer.BringToFront();
            userManageSystemUsers.Visible = false;
            userPurchaseAndSales.Visible = false;
            userSystemUsers.Visible = false;
            BtnNewSystemUsers.Visible = false;
            BtnManageSystemUsers.Visible = false;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            userDealerCustomer.Visible = false;
            userLogin.Visible = false;
            BtnNewDealersCustomers.Visible = false;
            BtnPurchasesSales.Visible = false;
            BtnNewSystemUsers.Visible = false;
            BtnManageSystemUsers.Visible = false;
        }

        private void BtnPurchasesSales_Click(object sender, EventArgs e)
        {
            userPurchaseAndSales.Visible = true;
            userPurchaseAndSales.BringToFront();
        }

        private void BtnSystemUsers_Click(object sender, EventArgs e)
        {
            pnlSidePanel.Location = new Point(0, 334);
            pnlSidePanel.BringToFront();
            i = i + 1;
            if (i%2==0)
            {
                BtnNewSystemUsers.Visible = true;
                BtnManageSystemUsers.Visible = true;
                BtnSettings.Visible = false;
            }
            else
            {
                BtnNewSystemUsers.Visible = false;
                BtnManageSystemUsers.Visible = false;
                BtnSettings.Visible = true;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            pnlSidePanel.BackColor = Color.Wheat;
            pnlSidePanel.Location = new Point(0, 443);
            pnlSidePanel.Size = new Size(7, BtnExit.Height);
            if (MessageBox.Show("Do you want o exit the system?\nSave all your information before its lost. Unsaved work will be lost", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {

                Application.Exit();
            }
            pnlSidePanel.Location = new Point(0, 69);
            pnlSidePanel.Size = new Size(7, btnDashboard.Height);
        }

        private void BtnNewSystemUsers_Click(object sender, EventArgs e)
        {
            userSystemUsers.Visible = true;
            userSystemUsers.BringToFront();
        }

        private void BtnManageSystemUsers_Click(object sender, EventArgs e)
        {
            userManageSystemUsers.Visible = true;
            userManageSystemUsers.BringToFront();
        }

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            pnlSidePanel.Location = new Point(0, 175);
            pnlSidePanel.BringToFront();
        }

        private void BtnStudentDetails_Click(object sender, EventArgs e)
        {
            pnlSidePanel.Location = new Point(0, 228);
            pnlSidePanel.BringToFront();
        }

        private void BtnAdminBoard_Click(object sender, EventArgs e)
        {
            pnlSidePanel.Location = new Point(0, 281);
            pnlSidePanel.BringToFront();
            userLogin.Visible = true;
            userLogin.BringToFront();
        }
    }
}
