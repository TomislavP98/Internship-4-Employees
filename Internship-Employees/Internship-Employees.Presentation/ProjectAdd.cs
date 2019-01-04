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
    public partial class ProjectAdd : Form
    {
        public ProjectAdd()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ProjectAddBackBttton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProjectAddEmployeeAddButton_Click(object sender, EventArgs e)
        {
            ProjectAddEmployee NewProjEmp = new ProjectAddEmployee();
            NewProjEmp.ShowDialog();
        }
    }
}
