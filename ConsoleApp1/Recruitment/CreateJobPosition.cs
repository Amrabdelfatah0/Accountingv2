using ConsoleApp1.bases;
using ConsoleApp1.Employes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Recruitment
{
    public class CreateJobPosition : BaseWithName

    {
        public string Email { get; set; }

        public List<JobPosition> JobPosition { get; set; }
        public Employees Employees { get; set; }

    }
}
