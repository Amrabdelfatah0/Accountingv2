using ConsoleApp1.bases;
using ConsoleApp1.customers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Suppliers
{
    public class Payments: Base  
    {
        public string TheSupplier { get; set; }//المورد
        public DateTime Date { get; set; }//التاريخ
        public string Statment { get; set; }
        public string OwnBankAccount { get; set; }//حساب البنك الخاص


    }
}
