using Accounting.bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Suppliers
{
    public class Suppliers : Base
    {
        public bool type { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string taxId { get; set; }
        public int PhoneNumber { get; set; }
        public int mobile { get; set; }
        public string eMail { get; set; }
        public string website { get; set; }
        public string Tags { get; set; }
    }
}
