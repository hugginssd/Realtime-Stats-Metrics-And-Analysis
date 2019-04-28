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
    public partial class UserPurchaseAndSales : UserControl
    {
        public UserPurchaseAndSales()
        {
            InitializeComponent();
        }
        TransactionBLL tbll = new TransactionBLL();
        TransactionDAL tdal = new TransactionDAL();
        ProductsBLL pbll = new ProductsBLL();
        ProductsDAL pdll = new ProductsDAL();
        TransactionDetailBLL tdbll = new TransactionDetailBLL();
        TransactionDetailsDAL tddall = new TransactionDetailsDAL();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                pbll.AddedBy = 1;
                pbll.AddedDate = DateTime.Now;
                pbll.Name = txtNameProduct.Text;
                pbll.Qty = int.Parse(txtQty.Text);
                pbll.Rate = decimal.Parse(txtRate.Text);
                bool IsSuccess = pdll.Insert(pbll);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                tdbll.GrandTotal = decimal.Parse(txtGrandtotal.Text);
                tdbll.Discount = decimal.Parse(txtDiscount.Text);
                tdbll.Qty = int.Parse(txtQty.Text);
                bool IsSuccess = tddall.InsertTransactionDetail(tdbll);
                if (IsSuccess)
                {
                    MessageBox.Show("Successfull");
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
    }
}
