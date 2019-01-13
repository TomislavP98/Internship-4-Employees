using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship_Employees.Data.Models
{
   public class Projects
    {
        public string Name { get; set; }
        public DateTime ProjectStart { get; set; }
        public DateTime ProjectFinish { get; set; }

        public Projects(string name, DateTime projectstart, DateTime projectfinish)
        {
            Name = name;
            ProjectStart = projectstart;
            ProjectFinish = projectfinish;
        }

        public bool Started()
        {
            return ProjectStart.Date <= DateTime.Now.Date;
        }

        public bool Finished()
        {
            return ProjectFinish.Date <= DateTime.Now.Date;
        }

        public override string ToString()
        {
            return (
                $"Ime projekta: {Name} \n Početak projekta: {ProjectStart:dd/MM/yyyy} \n Kraj projekta: {ProjectFinish:dd/MM/yyyy}"
            );
        }
    }
}
