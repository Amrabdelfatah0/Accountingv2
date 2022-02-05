using ConsoleApp1.bases;
using ConsoleApp1.Parent;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace ConsoleApp1.ParentRelated
{
    public class Contact : Base
    {
        public string website { get; set; }
        public People people { get; set; }
        public List<Address> addresses { get; set; }
        public List<Phone> phone { get; set; }
       

    }
}
