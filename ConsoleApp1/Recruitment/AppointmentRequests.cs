using ConsoleApp1.Parent;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Recruitment
{
    public class AppointmentRequests : People

    {
        public Qualification Qualification { get; set; }

        public Section Section { get; set; }
        public Salary ExpectedSalary { get; set; }
        public Salary SuggestedSalary { get; set; }
        public DateTime Availability { get; set; }



    }
}
