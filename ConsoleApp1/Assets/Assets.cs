using ConsoleApp1.bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Assets
{
    public class assets : BaseWithName
    {
        public int OriginalAmount { get; set; }
        public string Currency { get; set; }
        public string Method { get; set; }
        public string Duration { get; set; }
        public DateTime StartDraining { get; set; }
        public string FixedAssetAccount { get; set; }
        public string DrainingAccount { get; set; }
        public string ExpenseAccount { get; set; }
        public string Daily { get; set; }
    }
}
