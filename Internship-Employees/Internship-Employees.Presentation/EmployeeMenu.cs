using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Internship_Employees.Data.Models;

namespace Internship_Employees.Presentation
{
    public partial class EmployeeMenu : Form
    {
        public EmployeeMenu()
        {
            InitializeComponent();
        }

        private void EmployeeMenuBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmployeeAddButton_Click(object sender, EventArgs e)
        {
            EmployeeAdd EmpAdd = new EmployeeAdd();
            EmpAdd.ShowDialog();
        }

        private void EmployeeListButton_Click(object sender, EventArgs e)
        {
            EmployeeList EmpList = new EmployeeList();
            EmpList.ShowDialog();
        }

        private void EmployeeDeleteButton_Click(object sender, EventArgs e)
        {
            EmployeeDelete EmpDel = new EmployeeDelete();
            EmpDel.ShowDialog();
        }
    }
}
