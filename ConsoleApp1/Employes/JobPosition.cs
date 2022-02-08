using ConsoleApp1.bases;
using ConsoleApp1.Recruitment;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Employes
{
    internal class JobPosition :BaseWithName
    {
        public string JobName { get; set; }
        public CreateJobPosition CreateJobPosition { get; set; }
    }
}
