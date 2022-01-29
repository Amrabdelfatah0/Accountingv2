using ConsoleApp1.bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Suppliers
{
    public class Invoices : BaseWithName
    {
        public string SupplierInvoice { get; set; }
        public int BatchReferenceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime DueDate { get; set; }
    }
}