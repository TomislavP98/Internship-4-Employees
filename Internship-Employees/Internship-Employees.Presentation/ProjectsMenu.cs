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
    public partial class ProjectsMenu : Form
    {
        public ProjectsMenu()
        {
            InitializeComponent();
            RefreshProjectsListBox();
        }

        //Back
        private void ProjectMenuBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshProjectsListBox()
        {
            ProjectHistroylistBox.Items.Clear();
            foreach (var project in ProjectList.AquireProjects())
            {
                ProjectHistroylistBox.Items.Add(project);
            }
        }


      
        //Edit
        private void ProjectDetailsButton_Click(object sender, EventArgs e)
        {
            var Projects= new List<Projects>();
            foreach (var CheckedProjects in ProjectHistroylistBox.CheckedItems)
            {
                Projects.Add(ProjectList.FindProject(CheckedProjects.ToString().GetProjectNameInCheck()));
            }
            if (Projects.Count == 0)
                return;

            foreach (var Project in Projects)
            {
                var editProject = new ProjectAdd(Project);
                editProject.ShowDialog();
            }
            RefreshProjectsListBox();
        }

        //Add
        private void NewProjectButton_Click(object sender, EventArgs e)
        {
            var addProject = new ProjectAdd();
            addProject.ShowDialog();
            RefreshProjectsListBox();
        }

        private void ProjectHistroylistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Detalji
        private void ProjectMenuDetailsButton_Click(object sender, EventArgs e)
        {
            var Projects = new List<Projects>();
            foreach (var ProjectProperty in ProjectHistroylistBox.CheckedItems)
            {
               Projects.Add(ProjectList.GetProjectByName(ProjectProperty.ToString().GetProjectNameInCheck()));
            }
            if (Projects.Count == 0)
                return;

            var projectDetails = new ProjectsDetail(Projects);
            projectDetails.ShowDialog();

        }


        //Lost button
        private void ProjectHistoryButton_Click(object sender, EventArgs e)
        {

        }
        //Lost button
        private void ProjectMenuDeleteButton_Click(object sender, EventArgs e)
        {
            var ProjectsMarkedforDestuction = new List<Projects>();
            foreach (var CheckedProject in ProjectHistroylistBox.CheckedItems)
            {
                ProjectsMarkedforDestuction.Add(ProjectList.FindProject(ProjectsMarkedforDestuction.ToString().GetProjectNameInCheck()));
            }
            if (ProjectsMarkedforDestuction.Count == 0)
                return;


            if (DialogResult.Yes == MessageBox.Show("Jeste li sigurni da zelite izbrisati odabrane stavke?", "Oprez!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                foreach (var project in ProjectsMarkedforDestuction)
                {
                    ProjectList.Remove(project);
                    foreach (var employee in EmployeesOnProject.GetEmployeesOnProject(project.Name))
                    {
                        EmployeesOnProject.Remove(EmployeesOnProject.GetRelation(employee.OIB, project.Name));
                    }
                }
            }
            else
            {
                this.Close();
            }
        }

        private void ProjectsMenu_Load(object sender, EventArgs e)
        {
          /*  var ProjectsMarkedforDestuction = new List<Projects>();
            foreach (var CheckedProject in ProjectHistroylistBox.CheckedItems)
            {
                ProjectsMarkedforDestuction.Add(ProjectList.FindProject(ProjectsMarkedforDestuction.ToString().GetProjectNameInCheck()));
            }
            if (ProjectsMarkedforDestuction.Count == 0)
                return;


            if (DialogResult.Yes == MessageBox.Show("Jeste li sigurni da zelite izbrisati odabrane stavke?", "Oprez!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                foreach (var project in ProjectsMarkedforDestuction)
                {
                    ProjectList.Remove(project);
                    foreach (var employee in EmployeesOnProject.GetEmployeesOnProject(project.Name))
                    {
                        EmployeesOnProject.Remove(EmployeesOnProject.GetRelation(employee.OIB, project.Name));
                    }
                }
            }
            else
            {
                this.Close();
            }*/
        }
    }
}
