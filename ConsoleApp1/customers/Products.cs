using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.bases.Model
{
    public class Products : BaseWithName

    {
        public bool IsService { get; set; } = false;// default value منتج أم خدمة
        public double SellingPrice { get; set; }//سعر البيع
        public double Cost { get; set; }//التكلفة
        public string Description { get; set; }//الوصف

        public List<InvoiceDetails> InvoiceDetails { get; set; }

    }
}
