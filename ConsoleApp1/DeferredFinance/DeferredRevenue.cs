using ConsoleApp1.bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.DeferredFinance
{
    public class DeferredRevenue: Deferred
    {
        public Acount DeferredRevenueCalculation { get; set; }//not string
        public Acount RevenueAccount { get; set; }//not string

    }
}
