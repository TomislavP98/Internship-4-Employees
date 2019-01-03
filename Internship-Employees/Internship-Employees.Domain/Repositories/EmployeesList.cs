using Internship_Employees.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship_Employees.Domain.Repositories
{
    public class EmployeesList
    {
        public List<Internship_Employees_Items> ListOfEmployees;

        public List<Internship_Employees_Items> GetAllEmployees()
        {
            return ListOfEmployees;
        }

        public bool DeleteEmployee(Internship_Employees_Items EmployeeToBeFound)
        {
            int Checker = 0;
            Internship_Employees_Items EmployeeToBeDeleted = null;
            foreach (var Internship_Employees_Items in GetAllEmployees())
            {
                if (Internship_Employees_Items.Name == EmployeeToBeFound.Name && Internship_Employees_Items.Surname == EmployeeToBeFound.Surname)
                {
                    EmployeeToBeDeleted = Internship_Employees_Items;
                    Checker++;
                    ListOfEmployees.Remove(EmployeeToBeDeleted);
                }
            }

            if (Checker == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
