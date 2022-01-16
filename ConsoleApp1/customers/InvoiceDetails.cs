using System;
using System.Collections.Generic;
using System.Text;

namespace Accounting.bases.Model
{
    public class InvoiceDetails
    {
        public Invoices Invoices { get; set; }

        public Products Products { get; set; }

        public  int  Quantity { get; set; }



    }
}
