using ConsoleApp1.bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ParentRelated
{
    public class Address:BaseWithName
    {
        public string Detailes { get; set; }
        public Contact contact { get; set; }
    }
}
