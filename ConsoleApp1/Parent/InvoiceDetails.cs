using ConsoleApp1.bases.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Parent
{
    public class InvoiceDetails //parent 
    {
        public SalesBill Invoices { get; set; }//اوبجكت من  الفاتورة
        public Products Products { get; set; }//اوبجكت من  المنتجات
        public  int  Quantity { get; set; } //الكمية
        // property of Invoice , becouse it is one to many relationship
        // property of total 
    }
}
