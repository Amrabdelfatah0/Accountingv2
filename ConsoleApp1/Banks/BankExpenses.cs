using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.bases;

namespace ConsoleApp1.Banks
{
    internal class BankExpenses : BaseWithName
    {
        public string Type { get; set; }
        public bool Checkout { get; set; }
        public string DiaryAvailability { get; set; }
        public string NewItem { get; set; }

        
    }
}
