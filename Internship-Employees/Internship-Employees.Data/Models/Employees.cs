using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship_Employees.Data.Models
{
    public class Employees
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDay { get; set; }
        public string OIB { get; set; }

        public Employees(string name, string surname, DateTime birthday, string oib)
        {
            Name = name;
            Surname = surname;
            BirthDay = birthday;
            OIB = oib;
        }


        public override string ToString()
        {

            return $" Ime: {Name}\n Prezime: {Surname}\n OIB: {OIB}\n Datum Rođenja: {BirthDay}\n";
        }



    }
}
