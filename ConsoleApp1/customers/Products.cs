using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.bases.Model
{
    public class Products : Base

    {
        public string? Name { get; set; }
        public bool ProductType { get; set; }
        public double SellingPrice { get; set; }
        public double Cost { get; set; }
        public string? Description { get; set; }

        public List<InvoiceDetails> InvoiceDetails { get; set; }

    }
}
