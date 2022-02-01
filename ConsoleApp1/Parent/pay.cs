using ConsoleApp1.customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.bases.Model
{
    public class pay : BaseWithName
    {
        public Clients Clients { get; set; }
        public PaymentType PaymentType { get; set; }//نوع السداد
        public double Amount { get; set; }//المبلغ أو الدفعة
        public bool IsMoverdInterial { get; set; }//نقل داخلي
        public JournalType journalType { get; set; }//نوع دفتر اليومية
        public string Descriptation { get; set; }//بيان
        public List<salesbill> Invoices { get; set; }    


    }
}
