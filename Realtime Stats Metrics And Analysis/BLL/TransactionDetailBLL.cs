using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realtime_Stats_Metrics_And_Analysis.BLL
{
    class TransactionDetailBLL
    {
        public int ID { get; set; }

        public string Type { get; set; }

        public int DeaCustID { get; set; }

        public decimal GrandTotal { get; set; }

        public decimal Rate { get; set; }

        public DateTime TransactionDate { get; set; }

        public decimal Tax { get; set; }
            
        public decimal Qty { get; set; }

        public decimal Discount { get; set; }
            
        public decimal AddedDate { get; set; }

        public int AddedBy { get; set; }
            
        public DataTable TransactionDetails { get; set; }
    }
}
