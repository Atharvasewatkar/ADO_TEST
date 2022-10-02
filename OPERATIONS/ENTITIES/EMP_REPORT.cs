using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPERATIONS.ENTITIES
{
    public class EMP_REPORT
    {
        public int    EmployeeID { get; set; }

        public string FIRSTNAME { get; set; }
        public string LASTNAME { get; set; }
        public int    ORDERID { get; set; }
        public int    TOTAL_ORDERS { get; set; }
    }
}
