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
    public partial class ProjectLists : Form
    {
        public ProjectLists()
        {
            InitializeComponent();
            RefreshListBox();
        }

        private void RefreshListBox()
        {
            ProjectListListBox.Items.Clear();
            foreach (var Project in ProjectList.AquireProjects())
            {
                ProjectListListBox.Items.Add(Project);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

       /* private void ViewDetailsButton_Click(object sender, EventArgs e)
        {
            var CheckedProjects = new List<Projects>();
            foreach (var CheckedProjectItem in ProjectListBox.CheckedItems)
            {
                checkedProjects.Add(ProjectRepo.GetProjectByName(checkedProjectItem.ToString().GetProjectName()));
            }
            if (checkedProjects.Count == 0)
                return;

            var projectDetails = new ProjectDetailsForm(checkedProjects);
            projectDetails.ShowDialog();
        }*/

        private void ProjectListBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProjectListChangeeButton_Click(object sender, EventArgs e)
        {
            var manageProjects = new ProjectsMenu();
            manageProjects.ShowDialog();
            RefreshListBox();
        }
    }
}
