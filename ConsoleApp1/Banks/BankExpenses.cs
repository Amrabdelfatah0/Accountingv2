using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.bases;

namespace ConsoleApp1.Banks
{
    internal class BankExpenses : BaseWithName// review , and create bank object and relate it with bank expenses
    {
        public BankExpensesType BankExpensesType { get; set; }
        public bool Checkout { get; set; }
        public string JournalsAvailability { get; set; }
        public NewItem NewItem { get; set; }
    }
}
