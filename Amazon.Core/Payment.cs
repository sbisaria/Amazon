using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Core
{
    public class Payment
    {
        public decimal TotalAmount { get; set; }
        public CreditCard CardDetails { get; set; }
    }
}
