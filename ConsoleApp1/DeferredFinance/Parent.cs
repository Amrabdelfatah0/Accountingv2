using ConsoleApp1.bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.DeferredFinance
{
    public class Parent : BaseWithName
    {
        public int OriginalValue { get; set; }
        public DateTime AcquisitionDate { get; set; }

        public string TheNumberProofs { get; set; }
        public DateTime Datefirstproof { get; set; }
        public string Currency { get; set; }
        public double AmountLeftProve { get; set; }
        public double AmountDeferredExpenses { get; set; }
        public string Daily { get; set; }


    }
}
