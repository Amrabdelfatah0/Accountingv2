using ConsoleApp1.bases;
using ConsoleApp1.ParentRelated;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Parent
{
    public class People:Base
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Contact contact { get; set; }
       
    }
}
