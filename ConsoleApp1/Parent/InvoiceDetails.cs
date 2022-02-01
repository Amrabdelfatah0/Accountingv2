using ConsoleApp1.bases.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Parent
{
    public class InvoiceDetails
    {
        public salesbill Invoices { get; set; }//اوبجكت من  الفاتورة

        public Products Products { get; set; }//اوبجكت من  المنتجات


        public  int  Quantity { get; set; } //الكمية


    }
}
