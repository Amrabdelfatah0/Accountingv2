using ConsoleApp1.bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Products
{
    internal class Products :BaseWithName
    {
        public string ProductName { get; set; }
        public string ProductType { get; set; }

        public double SalesPrice { get; set; }
        public double CustomerTaxes { get; set; }
        public double Cost { get; set; }
        public enum ProductCategory { }
        public string InternalReference	 { get; set; }
        public string Product { get; set; }
        public string Barcode { get; set; } // مش هيدخل فى عمليات حسابيه هو مجرد تطابق و سيرش
        public string InternalNotes { get; set; }

    }
}
