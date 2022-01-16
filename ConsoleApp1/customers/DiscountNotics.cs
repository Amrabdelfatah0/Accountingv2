using Accounting.bases;
using System;

namespace Accounting.bases.Model
{
    public class DiscountNotices : BaseWithDate
    {
        public string DiscountNoticeForACustomer { get; set; }
        public int BatchReferenceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime DueDate { get; set; }
    }
}
