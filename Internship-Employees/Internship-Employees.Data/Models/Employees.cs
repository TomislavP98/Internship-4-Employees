using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Internship_Employees.Data.Enums;

namespace Internship_Employees.Data.Models
{
    public class Employees
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDay { get; set; }
        public string OIB { get; set; }
        public CompanyPositions Rank { get; set; }


        public Employees(string name, string surname, DateTime birthday, string oib, CompanyPositions rank)
        {
            Name = name;
            Surname = surname;
            BirthDay = birthday;
            OIB = oib;
            Rank = rank;

        }


        public override string ToString()
        {

            return $" Ime: {Name}\n Prezime: {Surname}\n OIB: {OIB}\n Datum Rođenja: {BirthDay}\n Pozicija:{Rank} \n";
        }



    }
}
