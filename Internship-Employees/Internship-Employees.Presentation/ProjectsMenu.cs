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
    }
}
