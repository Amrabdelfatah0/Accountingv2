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
        public string Name { get; set; }//اسم العميل 
        public string Adress { get; set; }//عنوان العميل 
        public int Mobile { get; set; }//تليفون العميل 
        public string Email { get; set; }//الايميل 
        public List<pay>? Pays { get; set; } //ليست من الدفعات
        public List<Invoices> Invoices { get; set; }//ليست من الفواتير 



    }
}
