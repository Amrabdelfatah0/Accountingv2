using ConsoleApp1.bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.DeferredFinance
{
    public class Acount: BaseWithName
    {
        public List<DeferredRevenue> DeferredRevenue { get; set; }

        public string AcountType { get; set; }
    }
}
