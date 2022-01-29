using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.bases.Model
{
    public class InvoiceDetails
    {
        public Invoices Invoices { get; set; }//اوبجكت من  الفاتورة

        public Products Products { get; set; }//اوبجكت من  المنتجات


        public  int  Quantity { get; set; } //الكمية


    }
}
