using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Internship_Employees.Data.Models;
using Internship_Employees.Data.Enums;
using Internship_Employees.Domain.Repositories;
using Internship_Employees.Infrastructure.Extensions;

namespace Internship_Employees.Presentation
{
    
    public partial class ProjectsDetail : Form
    {
        private List<Projects> ProjectDetails { get; set; }
        public ProjectsDetail(List<Projects> projectdetails)
        {
            ProjectDetails = projectdetails;
            InitializeComponent();
            RefreshProjectDetails();
        }

        private void RefreshProjectDetails()
        {
            var detailsText = "";
            foreach (var Project in ProjectDetails)
            {
                detailsText += $"{Project.Name}\n{Project.ProjectStart:d} - {Project.ProjectFinish:d}\n\n";

                foreach (var Position in Enum.GetNames(typeof(CompanyPositions)))
                {
                    var PositionsOfEmployees = new List<Employees>();
                    foreach (var Employee in EmployeesOnProject.GetEmployeesOnProject(Project.Name))
                    {
                        if (Employee.Rank.ToString() == Position)
                            PositionsOfEmployees.Add(Employee);
                    }

                    if (PositionsOfEmployees.Count == 0) continue;

                    detailsText += $"{Position} ({PositionsOfEmployees.Count})\n";

                    foreach (var employee in PositionsOfEmployees)
                    {
                        detailsText +=
                            $"\t{employee.Name} {employee.Surname} ({EmployeesOnProject.GetRelation(employee.OIB, Project.Name).WorkHours} hours)\n";
                    }

                    detailsText += "\n";
                }

                detailsText += "\n";
            }

            ProjectDetailslistBox.Text = detailsText;
        }

        private void ProjectDetailBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
