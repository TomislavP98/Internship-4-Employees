using Internship_Employees.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Internship_Employees.Data.Enums;


namespace Internship_Employees.Domain.Repositories
{
    public static class EmployeesList
    {
        public static List<Employees> ListOfEmployees = new List<Employees>()
        {
            new Employees("Ante","Antic",DateTime.Now.Subtract(new TimeSpan(366*20, 0, 0, 0)), "99999", CompanyPositions.Dizajner)
        };
        


        public static List<Employees> GetAllEmployees()
        {
            return ListOfEmployees;
        }


        public static Employees FindEmployeeByOIB(string oib)
        {
            foreach (var Employee in ListOfEmployees)
            {
                if (Employee.OIB == oib)
                    return Employee;
            }
            return null;
        }

        public static void EmployeeDelete(Employees EmployeeToBeRemoved)
        {
            ListOfEmployees.Remove(EmployeeToBeRemoved);
        }

        public static bool AddEmployee(string name, string surname, DateTime birthday, string oib, CompanyPositions rank)
        {
            foreach (var Employee in ListOfEmployees)
            {
                if (Employee.OIB == oib)
                    return false;
            }
            var NewEmployee = new Employees(name, surname, birthday, oib, rank);
            ListOfEmployees.Add(NewEmployee);
            return true;
        }

        
    }
}
