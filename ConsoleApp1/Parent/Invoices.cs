using ConsoleApp1.bases;
using ConsoleApp1.bases.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Parent
{
    public class Invoices : Base //parent

    {
        public DateTime InvoiceDate { get; set; }
        public DateTime DueDate { get; set; }
        public List<Products> Products { get; set; } 
        public List<Payment> Pay { get; set; }
        public int BatchReferenceNumber { get; set; }
        public List<InvoiceDetails> InvoiceDetails { get; set; }
    }
}
