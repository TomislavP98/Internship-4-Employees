using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Internship_Employees.Data.Enums;
using Internship_Employees.Data.Models;
using Internship_Employees.Domain.Repositories;
using Internship_Employees.Infrastructure.Extensions;

namespace Internship_Employees.Presentation
{
    public partial class EmployeeLists : Form
    {
        public EmployeeLists()
        {
            InitializeComponent();
            RefreshEmployeeInfo();
        }

        private void RefreshEmployeeInfo()
        {
            EmployeeListslistView.Items.Clear();

            EmployeeListslistView.Columns.Add("Ime:", -1, HorizontalAlignment.Left);
            EmployeeListslistView.Columns.Add("Prezime:", -1, HorizontalAlignment.Left);
            EmployeeListslistView.Columns.Add("Datum rođenja:", -1, HorizontalAlignment.Left);
            EmployeeListslistView.Columns.Add("OIB:", -1, HorizontalAlignment.Left);
            EmployeeListslistView.Columns.Add("Pozicija:", -1, HorizontalAlignment.Left);
            EmployeeListslistView.Columns.Add("Radni sati(ovaj tjedan);", -1, HorizontalAlignment.Left);
            EmployeeListslistView.Columns.Add("Zavrsenih projekata:", -1, HorizontalAlignment.Left);
            EmployeeListslistView.Columns.Add("Trenutno aktivnih projekata:", -1, HorizontalAlignment.Left);
            EmployeeListslistView.Columns.Add("Nadolazeci projekti:", -1, HorizontalAlignment.Left);

            foreach (var Employee in EmployeesList.GetAllEmployees())
            {
                var EmployeeProperty = new ListViewItem(Employee.Name);

                if (EmployeesOnProject.EmployeeThisWeeksWorkHours(Employee.OIB) > 40)
                    EmployeeProperty.BackColor = Color.DarkSlateGray; //stavi novu
                else if (EmployeesOnProject.EmployeeThisWeeksWorkHours(Employee.OIB) < 30)
                    EmployeeProperty.BackColor = Color.Goldenrod;
                else
                    EmployeeProperty.BackColor = Color.Aquamarine;

                EmployeeProperty.SubItems.Add(Employee.Surname);
                EmployeeProperty.SubItems.Add($"{Employee.BirthDay:d}");
                EmployeeProperty.SubItems.Add(Employee.OIB);
                EmployeeProperty.SubItems.Add(Employee.Rank.ToString());
                EmployeeProperty.SubItems.Add(EmployeesOnProject.EmployeeThisWeeksWorkHours(Employee.OIB).ToString());

                var FinishedProjects = 0;
                var ActiveProjects = 0;
                var FutureProjects = 0;
                foreach (var Project in EmployeesOnProject.GetProjectsByEmployee(Employee.OIB))
                {
                    if (Project.Finished())
                        FinishedProjects++;
                    if (Project.Started() && !Project.Finished())
                        ActiveProjects++;
                    if (Project.Started())
                        FutureProjects++;
                }

                EmployeeProperty.SubItems.Add(FinishedProjects.ToString());
                EmployeeProperty.SubItems.Add(ActiveProjects.ToString());
                EmployeeProperty.SubItems.Add(FutureProjects.ToString());

                EmployeeListslistView.Items.Add(EmployeeProperty);
            }

        }


        private void EmployeeeListsBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmployeeListsChangeButton_Click(object sender, EventArgs e)
        {
            var ManEmp = new EmployeeMenu();
            ManEmp.ShowDialog();
            RefreshEmployeeInfo();
        }
    }
}
