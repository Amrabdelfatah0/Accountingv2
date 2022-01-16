using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Suppliers
{
    public class Payments
    {
        public bool PaymentType { get; set; }
        public string TheSupplier { get; set; }
        public int TheAmount { get; set; }
        public DateTime Date { get; set; }
        public string Statment { get; set; }
        public string DailyNotebook { get; set; }
        public string OwnBankAccount { get; set; }

    }
}
