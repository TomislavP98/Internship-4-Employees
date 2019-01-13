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
    public partial class AddProjectWorkHours : Form
    {
        public int HoursToAdd { get; set; }
        public AddProjectWorkHours(string ProjectName, string EmployeeName)
        {   

            InitializeComponent();
            ProjectWorkHoursBackButton.Text = ProjectName;
            EmployeeNameWorkHoursLabel.Text = EmployeeName;
            HoursToAdd = 0;
        }

        public sealed override string Text
        {
            get => base.Text;
            set => base.Text = value;
        }

        private void ProjectWorkHoursBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProjectWorkHoursConfirmButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ProjectWorkHourstextBox.Text))
                HoursToAdd = int.Parse(ProjectWorkHourstextBox.Text);
            Close();
        }

        private void ProjectWorkHourstextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
