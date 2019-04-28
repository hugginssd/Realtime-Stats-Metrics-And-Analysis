using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realtime_Stats_Metrics_And_Analysis.BLL
{
    class TransactionBLL
    {

        public int ID { get; set; }

        public decimal Rate { get; set; }

        public int Qty { get; set; }

        public decimal Total { get; set; }

        public int DeaCustID { get; set; }

        public DateTime AddedDate { get; set; }

        public int AddedBy { get; set; }
    }
}
    