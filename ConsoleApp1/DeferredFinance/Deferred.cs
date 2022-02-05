using ConsoleApp1.bases;
using System;
using System.Collections.Generic;
using System.Text;
using static ConsoleApp1.Assets.assets;

namespace ConsoleApp1.DeferredFinance
{
    public class Deferred : BaseWithName
    {
        public int OriginalValue { get; set; }
        public DateTime AcquisitionDate { get; set; }
        public DurationType TheNumberInstallments { get; set; }// not string 
        // create property of Duration type Enum
        // create Agreed Time 
        public DateTime DateFirstInstallments { get; set; }
        public Currency Currency { get; set; } // object
        public double AmountLeftProve { get; set; }
        public double AmountDeferredExpenses { get; set; }
        public Daily Daily { get; set; }//not string
    }
}
