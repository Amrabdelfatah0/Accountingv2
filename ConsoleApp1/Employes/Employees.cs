using ConsoleApp1.bases;
using ConsoleApp1.Recruitment;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Employes
{
    internal class Employees : BaseWithName
    {
        //With Ahmed Salah
        public string JopPosition { get; set; }
        public string Rate { get; set; }
        public  string Email{ get; set; }   // حاولنا نعملها بفاريابل ايميل
        public enum Section { }
        public enum TheBoss { }
        public enum Coach { }
        public string WorkAdress { get; set; }
        public enum WorkHours { }
        public enum TimeZone { }

        public CreateJobPosition CreateJobPosition { get; set; } 



    }
}
