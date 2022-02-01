using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using ConsoleApp1.Parent;

namespace ConsoleApp1.bases.Model
{
    public class Clients : People
    {
        public List<Payment> Pays { get; set; } //ليست من الدفعات
        public List<SalesBill> Invoices { get; set; }//ليست من الفواتير 
    }
}
