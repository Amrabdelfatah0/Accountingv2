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
    //Payment class will be parent, and need to create child classes ( PurchesePayment and SalesPaymeny )
    public class Payment : BaseWithName
    {
        public PaymentType PaymentType { get; set; }//نوع السداد
        public double Amount { get; set; }//المبلغ أو الدفعة
        public bool IsMoverdInterial { get; set; }//نقل داخلي
        public JournalType journalType { get; set; }//نوع دفتر اليومية
        public string Descriptation { get; set; }//بيان
        
        // you dont need to relat invoices to this class.
        public List<SalesBill> Invoices { get; set; }

        public List<Purchasesbill> PurchasesBill { get; set; }

        public Invoices Invoices { get; set; }

    }
}
