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
    public partial class ProjectDetailsSearch : Form
    {
        public ProjectDetailsSearch()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProjectSearchSearchButton_Click(object sender, EventArgs e)
        {
            FoundProjectDetails FoundProj = new FoundProjectDetails();
           FoundProj.ShowDialog();
        }

        private void ProjectSearchBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
