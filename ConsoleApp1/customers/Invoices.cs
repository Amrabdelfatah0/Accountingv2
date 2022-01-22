using Accounting.bases;
using System;
using System.Collections.Generic;

namespace Accounting.bases.Model
{
    public class Invoices : BaseWithDate
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
