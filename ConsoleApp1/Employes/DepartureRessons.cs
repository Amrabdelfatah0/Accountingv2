using ConsoleApp1.bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Employes
{
    internal class DepartureRessons :BaseWithName
    {
        public bool Fired { get; set; }
        public bool Resigned { get; set; }
        public bool Retirement { get; set; }

    }
}
