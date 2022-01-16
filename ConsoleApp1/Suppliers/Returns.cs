using Accounting.bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Suppliers
{
    public class Returns : BaseWithDate
    {
        public string supplierDiscountNotice { get; set; }
        public string theSupplier { get; set; }
        public string invoiceReferenceNumber { get; set; }
        public string batchReferenceNumber { get; set; }
        public string recipientBank { get; set; }
        public DateTime invoiceDate { get; set; }
        public DateTime accountingHistory { get; set; }
        public DateTime dueDate { get; set; }
        public string dailyNotebook { get; set; }
    }
}
