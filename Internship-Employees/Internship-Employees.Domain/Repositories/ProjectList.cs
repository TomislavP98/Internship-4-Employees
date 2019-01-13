using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Internship_Employees.Data.Models;

namespace Internship_Employees.Domain.Repositories
{
    public static class ProjectList
    {
                 private static readonly List<Projects> ListOfProjects = new List<Projects>()
                 {
                        new Projects("Skype That Acutually Works", DateTime.Now, DateTime.Now.AddDays(25))
                 };

        public static List<Projects> AquireProjects()
        {
            return ListOfProjects;
        }

        public static Projects FindProject(string name)
        {
            foreach (var Project in ListOfProjects)
            {
                if (Project.Name == name)
                    return Project;
            }
            return null;
        }

       

        public static void Remove(Projects ProjectToBeRemoved)
        {
            ListOfProjects.Remove(ProjectToBeRemoved);
        }

        public static Projects GetProjectByName(string name)
        {
            foreach (var Project in ListOfProjects)
            {
                if (Project.Name == name)
                    return Project;
            }
            return null;
        }


        public static bool AddProject(string name, DateTime projectstart, DateTime projectfinish)
        {
            foreach (var Project in ListOfProjects)
            {
                if (Project.Name == name)
                    return false;
            }
            var NewProject = new Projects(name, projectstart, projectfinish);
            ListOfProjects.Add(NewProject);
            return true;
        }
    }
}
    


