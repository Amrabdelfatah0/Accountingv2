using ConsoleApp1.bases;
using System;
using System.Collections.Generic;

namespace ConsoleApp1.bases.Model
{
    public class salesbill : BaseWithName
    {
        public Clients? Clients { get; set; }
        public Tax Tax { get; set; }//الضرائب



    }
}
