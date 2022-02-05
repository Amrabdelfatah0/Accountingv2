using ConsoleApp1.bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.DeferredFinance
{
    public class DeferredRevenue: Deferred
    {
        public DeferredRevenueCalculation DeferredRevenueCalculation { get; set; }//not string
        public RevenueAccount RevenueAccount { get; set; }//not string

    }
}
