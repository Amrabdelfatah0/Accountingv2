using ConsoleApp1.Parent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.bases.Model
{
    public class Users : People
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
