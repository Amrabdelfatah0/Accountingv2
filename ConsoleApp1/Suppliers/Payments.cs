using ConsoleApp1.customers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Suppliers
{
    public class Payments
    {
        public string TheSupplier { get; set; }//المورد
        public int TheAmount { get; set; }//المبلغ
        public DateTime Date { get; set; }//التاريخ
        public string Statment { get; set; }
        public string DailyNotebook { get; set; }//دفتر اليومية 
        public string OwnBankAccount { get; set; }//حساب البنك الخاص
        public PaymentType PaymentType { get; set; }//نوع السداد


    }
}
