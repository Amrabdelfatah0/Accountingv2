using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.bases.Model
{
    public class pay : BaseWithName
    {
        public Clients? Clients { get; set; }
        public bool PaymentType { get; set; }//نوع السداد
        public double Amount { get; set; }//المبلغ أو الدفعة
        public bool Journal { get; set; }//دفتر اليومية
        
        public List<Invoices> Invoices { get; set; }    


    }
}
