using ConsoleApp1.bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Suppliers
{
    // this chiled class of Invoice
    // this model need to be relat with Supplier.
    public class Purchasesbill : BaseWithName
    {
        public string SupplierInvoice { get; set; }//not string
    }
}