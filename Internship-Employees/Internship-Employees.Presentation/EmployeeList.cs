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

namespace Internship_Employees.Presentation
{
    public partial class EmployeeList : Form
    {
       
        public EmployeeList()
        {
            InitializeComponent();
           
        }
        
       
      

        private void EmployeListBasckButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
