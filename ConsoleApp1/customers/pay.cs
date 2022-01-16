using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.bases.Model
{
    public class pay : BaseWithDate
    {
        public Clients? Clients { get; set; }
        public bool PaymentType { get; set; }
        public double Amount { get; set; }
        public bool Journal { get; set; }
        
        public List<Invoices> Invoices { get; set; }    


    }
}
