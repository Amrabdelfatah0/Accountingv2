using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.bases.Model
{
    public class Products : Base

    {
        public string? Name { get; set; }//اسم المنتج
        public bool ProductType { get; set; }//نوع المنتج
        public double SellingPrice { get; set; }//سعر البيع
        public double Cost { get; set; }//التكلفة
        public string? Description { get; set; }//الوصف

        public List<InvoiceDetails> InvoiceDetails { get; set; }

    }
}
