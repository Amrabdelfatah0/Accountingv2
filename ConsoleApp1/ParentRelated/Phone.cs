using ConsoleApp1.bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ParentRelated
{
    public class Phone:Base
    {
        public string phoneNumber { get; set; }
        public Contact contact { get; set; }
    }
}
