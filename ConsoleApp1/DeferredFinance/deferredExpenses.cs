using ConsoleApp1.bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.DeferredFinance
{
    public class DeferredExpenses : Deferred
    {
        public string DeferredExpensesCalculation { get; set; }//not string
        public string ExpenseAccount { get; set; }//not string
    }
}
