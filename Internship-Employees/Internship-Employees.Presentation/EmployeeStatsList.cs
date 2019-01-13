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
    public partial class EmployeeStatsList : Form
    {
        public EmployeeStatsList()
        {
            InitializeComponent();
            RefreshEmployeesListBox();
        }

        private void RefreshEmployeesListBox()
        {
            EmployeeStatsListView.Items.Clear();
            AddEmployeeInBox(EmployeeStatsListView);
            foreach (var employee in EmployeesList.GetAllEmployees())
            {
                var EmployeeProperties = new ListViewItem(employee.Name);
                AddEmployeeColors(EmployeeProperties, employee);
                AddEmployeeProperties(EmployeeProperties, employee);
                AddEmployeeProjects(EmployeeProperties, employee);
                EmployeeStatsListView.Items.Add(EmployeeProperties);
            }

        }

        private static void AddEmployeeInBox(ListView destination)
        {
            destination.Columns.Add("Ime:", -1, HorizontalAlignment.Left);
            destination.Columns.Add("Prezime:", -1, HorizontalAlignment.Left);
            destination.Columns.Add("Datum rođenja:", -1, HorizontalAlignment.Left);
            destination.Columns.Add("OIB:", -1, HorizontalAlignment.Left);
            destination.Columns.Add("Pozicija:", -1, HorizontalAlignment.Left);
            destination.Columns.Add("Zavrseni projekti:", -1, HorizontalAlignment.Left);
            destination.Columns.Add("Aktivni projekti:", -1, HorizontalAlignment.Left);
            destination.Columns.Add("Nadolazeci projekti:", -1, HorizontalAlignment.Left);
            destination.Columns.Add("Obavljeni radni sati:", -1, HorizontalAlignment.Left);

        }

        private static void AddEmployeeProperties(ListViewItem destination, Employees Source)
        {
            destination.SubItems.Add(Source.Surname);
            destination.SubItems.Add($"{Source.BirthDay:d}");
            destination.SubItems.Add(Source.OIB);
            destination.SubItems.Add(Source.Rank.ToString());
            destination.SubItems.Add(EmployeesOnProject.EmployeeThisWeeksWorkHours(Source.OIB).ToString());
        }

        private static void AddEmployeeColors(ListViewItem destination, Employees SourceWorkHours)
        {

            if (EmployeesOnProject.EmployeeThisWeeksWorkHours(SourceWorkHours.OIB) > 40)
                destination.BackColor = Color.Red;
            else if (EmployeesOnProject.EmployeeThisWeeksWorkHours(SourceWorkHours.OIB) < 30)
                destination.BackColor = Color.Goldenrod;
            else
                destination.BackColor = Color.MediumSeaGreen;
        }
        private static void AddEmployeeProjects(ListViewItem destination, Employees SourceProjects)
        {
            var FinishedProjects = 0;
            var ActiveProjects = 0;
            var SoonToComeProjects = 0;
            foreach (var Project in EmployeesOnProject.GetProjectsByEmployee(SourceProjects.OIB))
            {
                if (Project.Started())
                    FinishedProjects++;
                if (Project.Started() && !Project.Finished())
                    ActiveProjects++;
                if (!Project.Started())
                    SoonToComeProjects++;
            }

            destination.SubItems.Add(FinishedProjects.ToString());
            destination.SubItems.Add(ActiveProjects.ToString());
            destination.SubItems.Add(SoonToComeProjects.ToString());
        }


        private void EmployeeStatsBckButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmployeeStatsEditButton_Click(object sender, EventArgs e)
        {
                var EditEmp = new EmployeeMenu();
                EditEmp.ShowDialog();
                RefreshEmployeesListBox();
            
        }
    }
}
