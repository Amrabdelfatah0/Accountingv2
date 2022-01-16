using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Accounting.bases.Model
{
    public class Clients : Base
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public int Id { get; set; }
        public int Mobile { get; set; }
        public string Email { get; set; }
        public List<pay>? Pays { get; set; }
        public List<Invoices> Invoices { get; set; }



    }
}
