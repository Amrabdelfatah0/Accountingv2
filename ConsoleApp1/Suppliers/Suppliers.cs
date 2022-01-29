using ConsoleApp1.bases;
using ConsoleApp1.Parent;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Suppliers
{
    public class Suppliers : People
    {
        public bool type { get; set; }
        public string taxId { get; set; }
        public int PhoneNumber { get; set; }
        
        public string Tags { get; set; }
    }
}
