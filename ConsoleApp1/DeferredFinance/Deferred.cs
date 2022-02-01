using ConsoleApp1.bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.DeferredFinance
{
    public class Deferred : BaseWithName
    {
        public int OriginalValue { get; set; }
        public DateTime AcquisitionDate { get; set; }
        public string TheNumberInstallments { get; set; }// not string 
        // create property of Duration type Enum
        // create Agreed Time 
        public DateTime DateFirstInstallments { get; set; }
        public string Currency { get; set; } // object
        public double AmountLeftProve { get; set; }
        public double AmountDeferredExpenses { get; set; }
        public string Daily { get; set; }//not string
    }
}
