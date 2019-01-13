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
    public partial class AddEmployeeWorkHours : Form
    {
        public int HoursToAdd { get; set; }
        
        public AddEmployeeWorkHours(string ProjectName, string EmployeeName)
        {
            InitializeComponent();
            ProjectLableEmployeeWorkhours.Text = ProjectName;
            EmployeeLabel.Text = ProjectName;
            HoursToAdd = 0;

        }

        public sealed override string Text
        {
            get => base.Text;
            set => base.Text = value;
        }

        private void EmployeeAddWorkHourstextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeAddWorkHourstextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ProjectLableEmployeeWorkhours_Click(object sender, EventArgs e)
        {

        }

        private void workhoursEmployeeBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CofnrimButtonWorkhours_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(EmployeeAddWorkHourstextBox.Text))
                HoursToAdd = int.Parse(EmployeeAddWorkHourstextBox.Text);
            Close();
        }
    }
}
