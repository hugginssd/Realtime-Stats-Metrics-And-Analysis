using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realtime_Stats_Metrics_And_Analysis.DAL
{
    class UserDAL
    {
        public string connection = ConfigurationManager.ConnectionStrings["realtime"].ToString();
    }
}
