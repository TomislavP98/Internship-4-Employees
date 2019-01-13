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
    public partial class EmployeeDeleteError : Form
    {
        public EmployeeDeleteError()
        {
            InitializeComponent();
        }

        private void ErrorOkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
