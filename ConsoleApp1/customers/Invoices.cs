using Accounting.bases;
using System;
using System.Collections.Generic;

namespace Accounting.bases.Model
{
    public class Invoices : BaseWithDate
    {
        public Clients? Clients { get; set; }
        public int BatchReferenceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime DueDate { get; set; }
        public Tax Tax { get; set; }

        public List<InvoiceDetails> InvoiceDetails { get; set; }
        public pay pay { get; set; }


    }
}
