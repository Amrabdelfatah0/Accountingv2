using ConsoleApp1.customers;
using ConsoleApp1.Parent;
using ConsoleApp1.Suppliers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.bases.Model
{
    public class pay : BaseWithName
    {
        public PaymentType PaymentType { get; set; }//نوع السداد
        public double Amount { get; set; }//المبلغ أو الدفعة
        public bool IsMoverdInterial { get; set; }//نقل داخلي
        public JournalType journalType { get; set; }//نوع دفتر اليومية
        public string Descriptation { get; set; }//بيان
        public List<salesbill> Invoices { get; set; }

        public List<Purchasesbill> PurchasesBill { get; set; }

        public Invoices Invoices { get; set; }

    }
}
