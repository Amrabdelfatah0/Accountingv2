using ConsoleApp1.bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Assets
{
    public class Assets : BaseWithName
    { 
        public int OriginalValue { get; set; }
        public enum Currency {}
        public MethodType methodType { get; set; }
        public double NotDepreciableValue { get; set; }
        public double BookValue { get; set; }
        public int DurationAmount { get; set; }//double
        // create property of Duration Type (Years or monthes) => Enum
        public DateTime StartDepreciating { get; set; }
        public enum FixedAssetAccount { }//not string, this is a class not an enum
                                         // create property to agreeced time التانسب الزمني
        public enum DrainingAccount { }//not string, this is a class not an enum
        public enum ExpenseAccount { }//not string, this is a class not an enum
        public enum Journal { }//not string, this is a class not an enum
        // Last four properties are a class called account.
    }
}
