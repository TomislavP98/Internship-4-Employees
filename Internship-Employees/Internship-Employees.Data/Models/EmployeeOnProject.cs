using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship_Employees.Data.Models
{
    public class EmployeeOnProject
    {
        public string ProjectName { get; set; }
        public string OIB { get; set; }
        public int WorkHours { get; set; }

        public EmployeeOnProject(string projectname, string oib, int workhours)
        {
            ProjectName = projectname;
            OIB = oib;
            WorkHours = workhours;
        }
    }
}
