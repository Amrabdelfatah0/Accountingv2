using ConsoleApp1.bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Assets
{
    public class assets : BaseWithName
    {
        public int OriginalAmount { get; set; }
        public string Currency { get; set; }//not string
        public DateTime StartDraining { get; set; }
        public string Method { get; set; }// not string
        public string Duration { get; set; }//not string , Name it Duratation Amount
        // create property of Duration Type (Years or monthes) => Enum
        public string FixedAssetAccount { get; set; }//not string
        // create property to agreeced time التانسب الزمني
        public string DrainingAccount { get; set; }
        public string ExpenseAccount { get; set; }
        public string Daily { get; set; }
    }
}
