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
using Internship_Employees.Domain.Repositories;
using Internship_Employees.Infrastructure.Extensions;



namespace Internship_Employees.Presentation
{
    public partial class EmployeeAdd : Form
    {
        public  EmployeeAdd()
        {
            InitializeComponent();
        }

        private void EmployeAddBackButton_Click(object sender, EventArgs e)
        {
           this.Close();
        }

      

        private void EmployeeAddAddButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
