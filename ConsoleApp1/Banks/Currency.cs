using ConsoleApp1.bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Banks
{
    internal class Currency : BaseWithName
    {
        public string CurrencyType { get; set; }
        
        public bool Active { get; set; }
        public string CurrencyUnit { get; set; }
        public string CurrencySubunit { get; set; }
        public enum Rates { }

    }
}
