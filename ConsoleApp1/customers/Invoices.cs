using ConsoleApp1.bases;
using System;
using System.Collections.Generic;

namespace ConsoleApp1.bases.Model
{
    public class Invoices : BaseWithName
    {
        public Clients? Clients { get; set; }
        public int BatchReferenceNumber { get; set; }//الرقم المرجعي
        public DateTime InvoiceDate { get; set; }//تاريخ الفاتورة
        public DateTime DueDate { get; set; }//تاريخ الاستحقاق
        public Tax Tax { get; set; }//الضرائب

        public List<InvoiceDetails> InvoiceDetails { get; set; }
        public pay pay { get; set; }


    }
}
