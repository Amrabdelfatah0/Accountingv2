using ConsoleApp1.bases;
using System;

namespace ConsoleApp1.bases.Model
{
    public class DiscountNotices : BaseWithName 
    {
        public string DiscountNoticeForACustomer { get; set; }
        public int BatchReferenceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime DueDate { get; set; }
    }
}
