using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Internship_Employees.Data.Models;

namespace Internship_Employees.Domain.Repositories
{
    public static class EmployeesOnProject
    {
        private static readonly List<EmployeeOnProject> AllParticipants = new List<EmployeeOnProject>()
        {
            new EmployeeOnProject("Skype That Acutaslly Works", "1", 10),
          
        };

        public static List<EmployeeOnProject> GetAllRelations()
        {
            return AllParticipants;
        }

        public static bool TryRemove(EmployeeOnProject ToBeRemoved)
        {
            if (GetEmployeesOnProject(ToBeRemoved.ProjectName).Count == 1)
            {
                return false;
            }
            AllParticipants.Remove(ToBeRemoved);
            return true;
        }

        public static EmployeeOnProject GetRelation(string oib, string projectname)
        {
            foreach (var Relation in AllParticipants)
            {
                if (Relation.OIB == oib && Relation.ProjectName == projectname)
                    return Relation;
            }
            return null;
        }

        public static bool AddProject(string projectname, string oib, int workhours)
        {
            foreach (var Relation in AllParticipants)
            {
                if (Relation.ProjectName == projectname && Relation.OIB == oib)
                    return false;
            }

            var NewRelation = new EmployeeOnProject(projectname, oib, workhours);
            AllParticipants.Add(NewRelation);
            return true;
        }

        public static List<Employees> GetEmployeesOnProject(string projectname)
        {
            var employeesOnProject = new List<Employees>();
            foreach (var Relation in AllParticipants)
            {
                if (Relation.ProjectName == projectname)
                    employeesOnProject.Add(EmployeesList.FindEmployeeByOIB(Relation.OIB));
            }
            return employeesOnProject;
        }



        public static List<Projects> GetProjectsByEmployee(string oib)
        {
            var projectsByEmployee = new List<Projects>();
            foreach (var Relation in AllParticipants)
            {
                if (Relation.OIB == oib)
                    projectsByEmployee.Add(ProjectList.GetProjectByName(Relation.ProjectName));
            }

            return projectsByEmployee;
        }

        

        public static bool IsEmployeeOnProject(string oib, string projectName)
        {
            var projectsByEmployee = GetProjectsByEmployee(oib);
            foreach (var project in projectsByEmployee)
            {
                if (project.Name == projectName)
                    return true;
            }

            return false;
        }

        

        public static void Remove(EmployeeOnProject ToBeRemoved)
        {
            AllParticipants.Remove(ToBeRemoved);
        }

        public static int EmployeeThisWeeksWorkHours(string oib)
        {
            var AllEmployeeProjects = GetProjectsByEmployee(oib);
            var TotalHours = 0;

            foreach (var project in AllEmployeeProjects)
            {
                if (DateTime.Compare(project.ProjectStart, DateTime.Now.AddDays(7)) < 0 &&
                    DateTime.Compare(project.ProjectFinish, DateTime.Now) > 0)
                    TotalHours += GetRelation(oib, project.Name).WorkHours;
            }
            return TotalHours;
        }
    }
}
