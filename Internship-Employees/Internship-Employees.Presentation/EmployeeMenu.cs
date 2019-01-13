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
using Internship_Employees.Data.Enums;
using Internship_Employees.Domain.Repositories;
using Internship_Employees.Infrastructure.Extensions;

namespace Internship_Employees.Presentation
{
    public partial class EmployeeMenu : Form
    {
        public EmployeeMenu()
        {
            InitializeComponent();
            RefreshEmployeesListBox();
        }


        private void RefreshEmployeesListBox()
        {
            EmployeeMenucheckedListBox.Items.Clear();
          
            foreach (var employee in EmployeesList.GetAllEmployees())
            {
                EmployeeMenucheckedListBox.Items.Add(employee);
            }
        
        }

        private void EmployeeDeleteButton_Click(object sender, EventArgs e)
        {
            var Employee = new List<Employees>();
            foreach (var EmployeeProperty in EmployeeMenucheckedListBox.CheckedItems)
            {
                Employee.Add(EmployeesList.FindEmployeeByOIB(EmployeeProperty.ToString().GetOIBInCheck()));
            }

            if (Employee.Count == 0)
                return;

            if (DialogResult.Yes == MessageBox.Show("Jeste li sigurni da zelite izbrisati odabrane stavke?", "Oprez!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            { 
                foreach (var employees in Employee)
                {
                
                    DeleteEmployee(employees);

                    /*var ErrorCounter = 0;
                    foreach (var Project in EmployeesOnProject.GetProjectsByEmployee(employee.OIB))
                    {
                        if (EmployeesOnProject.TryRemove(
                            EmployeesOnProject.GetRelation(employee.OIB, Project.Name))) continue;
                        ErrorCounter++;
                        EmployeeDeleteError LastEmployeeError = new EmployeeDeleteError();
                        LastEmployeeError.ShowDialog();
                        
                        break;
                }
                    if (ErrorCounter == 0)
                        EmployeesList.EmployeeDelete(employee);*/
                }
            }

            RefreshEmployeesListBox();

        }

        private static void DeleteEmployee(Employees MarkedEmployee)
        {
            var ErrorCounter = 0;
            foreach (var project in EmployeesOnProject.GetProjectsByEmployee(MarkedEmployee.OIB))
            {
                if (EmployeesOnProject.TryRemove( EmployeesOnProject.GetRelation(MarkedEmployee.OIB, project.Name))) continue;
                ErrorCounter++;
                MessageBox.Show("Upozorenje!", "Ne možete izbrisati odabranog zaposlenika jer sam radi na jednom ili više projekata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                break;
            }
            if (ErrorCounter == 0)
                EmployeesList.EmployeeDelete(MarkedEmployee);
        }

      
        private void EmployeeMenuBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmployeeAddButton_Click(object sender, EventArgs e)
        {
            EmployeeAdd EmpAdd = new EmployeeAdd();
            EmpAdd.ShowDialog();
            RefreshEmployeesListBox();
        }


        private void EmployeeListButton_Click(object sender, EventArgs e)
        {

            var Employee = new List<Employees>();
            foreach (var CheckedEmployee in EmployeeMenucheckedListBox.CheckedItems)
            {
                Employee.Add(EmployeesList.FindEmployeeByOIB(CheckedEmployee.ToString().GetOIBInCheck()));
            }
            if (Employee.Count == 0)
                return;

            foreach (var employee in Employee)
            {
                var editProject = new EmployeeAdd(employee.Name, employee.Surname, employee.BirthDay, employee.OIB, employee.Rank);
                editProject.ShowDialog();
            }

            RefreshEmployeesListBox();
        }


    }
}
