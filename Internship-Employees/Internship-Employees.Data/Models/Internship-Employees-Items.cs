using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship_Employees.Data.Models
{
   public class Internship_Employees_Items
   {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDay { get; set; }

        public Internship_Employees_Items(string name, string surname, DateTime birthday)
        {
            Name = name;
            Surname = surname;
            BirthDay = birthday;
        }





   }
}
