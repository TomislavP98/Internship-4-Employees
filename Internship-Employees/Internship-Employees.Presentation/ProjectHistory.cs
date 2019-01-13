using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Internship_Employees.Data.Enums;
using Internship_Employees.Data.Models;
using Internship_Employees.Domain.Repositories;
using Internship_Employees.Infrastructure.Extensions;

namespace Internship_Employees.Presentation
{
    
    public partial class ProjectHistory : Form
    {
        private List<Projects> ProjectHistoryList { get; set; }
        public ProjectHistory(List<Projects> projecthistory)
        {
            ProjectHistoryList = projecthistory;
            InitializeComponent();
            RefreshProjects();
        }

        private void RefreshProjects()
        {
            var detailsText = "";
            foreach (var project in ProjectHistoryList)
            {
                detailsText += $"{project.Name}\n{project.ProjectStart:d} - {project.ProjectFinish:d}\n\n";

                foreach (var position in Enum.GetNames(typeof(CompanyPositions)))
                {
                    var positionEmployees = new List<Employees>();
                    foreach (var employee in EmployeesOnProject.GetEmployeesOnProject(project.Name))
                    {
                        if (employee.Rank.ToString() == position)
                            positionEmployees.Add(employee);
                    }

                    if (positionEmployees.Count == 0) continue;

                    detailsText += $"{position} ({positionEmployees.Count})\n";

                    foreach (var employee in positionEmployees)
                    {
                        detailsText +=
                            $"\t{employee.Name} {employee.Surname} ({EmployeesOnProject.GetRelation(employee.OIB, project.Name).WorkHours} hours)\n";
                    }

                    detailsText += "\n";
                }

                detailsText += "\n";
            }

            ProjectHistroylistBox.Text = detailsText;
        }

        private void ProjectHistoryBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProjectHistoryDeleteButton_Click(object sender, EventArgs e)
        {

            var checkedProjects = new List<Projects>();
            foreach (var checkedProjectItem in ProjectHistroylistBox.CheckedItems)
            {
                checkedProjects.Add(ProjectList.FindProject(checkedProjectItem.ToString().GetProjectNameInCheck()));
            }
            if (checkedProjects.Count == 0)
                return;

            if (DialogResult.Yes == MessageBox.Show("Jeste li sigurni da zelite izbrisati odabrane stavke?", "Oprez!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                foreach (var project in checkedProjects)
                {
                    ProjectList.Remove(project);
                    foreach (var employee in EmployeesOnProject.GetEmployeesOnProject(project.Name))
                    {
                        EmployeesOnProject.Remove(EmployeesOnProject.GetRelation(employee.OIB, project.Name));
                    }
                }
            }

            RefreshProjects();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
