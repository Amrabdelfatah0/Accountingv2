using ConsoleApp1.bases;
using ConsoleApp1.DeferredFinance;
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
        public DurationType DurationType { get; set; }//double
        // create property of Duration Type (Years or monthes) => Enum
        
        public DateTime StartDepreciating { get; set; }
        public  DateTime AgreecedTime { get; set; }
        
        public List<FixedAssetAccount> FixedAssetAccount { get; set; } //not string, this is a class not an enum
        public List<DepreciationAccount> DepreciationAccount { get; set; }//not string, this is a class not an enum
        public List<ExpenseAccount> ExpenseAccount { get; set; }//not string, this is a class not an enum
        public List<Journal> Journal  { get; set; }//not string, this is a class not an enum
        // Last four properties are a class called account.
    }
}
