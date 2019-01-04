using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internship_Employees.Presentation
{
    public partial class ProjectsMenu : Form
    {
        public ProjectsMenu()
        {
            InitializeComponent();
        }

        private void ProjectMenuBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProjectHistoryButton_Click(object sender, EventArgs e)
        {
            ProjectHistory ProjHis = new ProjectHistory();
            ProjHis.ShowDialog();
        }

        private void ProjectDetailsButton_Click(object sender, EventArgs e)
        {
            ProjectDetailsSearch ProjSea = new ProjectDetailsSearch();
            ProjSea.ShowDialog();
        }

        private void NewProjectButton_Click(object sender, EventArgs e)
        {
            ProjectAdd ProjAdd = new ProjectAdd();
            ProjAdd.ShowDialog();
        }
    }
}
