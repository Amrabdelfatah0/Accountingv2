using Accounting.bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Suppliers
{
    public class Returns : BaseWithDate
    {
        public string supplierDiscountNotice { get; set; }//اشعار خصم المورد
        public string theSupplier { get; set; }//المورد
        public string invoiceReferenceNumber { get; set; }//الرقم المرجعى للفاتورة
        public string batchReferenceNumber { get; set; }//رقم إشارة الدفع
        public string recipientBank { get; set; }
        public DateTime invoiceDate { get; set; }//تاريخ الفاتورة
        public DateTime accountingHistory { get; set; }//تاريخ المحاسبة
        public DateTime dueDate { get; set; }//تاريخ الاستحقاق
        public string dailyNotebook { get; set; }//دفتر اليومية
    }
}
