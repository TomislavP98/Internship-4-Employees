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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void StartEmployeesButton_Click(object sender, EventArgs e)
        {
            EmployeeStatsList EmpMenu = new EmployeeStatsList();
            EmpMenu.ShowDialog();
        }

        private void StartExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartProjectButton_Click(object sender, EventArgs e)
        {
            ProjectLists ProjMenu = new ProjectLists();
            ProjMenu.ShowDialog();
        }
    }
}
