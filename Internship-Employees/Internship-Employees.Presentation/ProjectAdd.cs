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
using Internship_Employees.Data.Enums;



namespace Internship_Employees.Presentation
{
    public partial class ProjectAdd : Form
    {
        public string OldName { get; set; }
        public bool Addition { get; set; }
        private readonly List<string> CheckedOIBs = new List<string>();


        public ProjectAdd()
        {
            InitializeComponent();
            ProjectAddDateTimeFinisch.Value = ProjectAddDateTimeStart.Value.AddDays(1);
            RefreshListBox();
            Addition = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public ProjectAdd(string name, DateTime start, DateTime finish)
        {
            OldName = name;

            InitializeComponent();
            ProjectAddNameTextBox.Text = name;
            ProjectAddDateTimeStart.Value = start;
            ProjectAddDateTimeFinisch.Value = finish;
            RefreshListBox();
            CheckEmployeesOnProject(name);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Jeste li sigurni da zelite izbrisati odabrane stavke?", "Oprez!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                this.Close();
            }
        }

        private void RefreshListBox()
        {
            ProjectAddcheckedListBox.Items.Clear();
            foreach (var Employee in EmployeesList.GetAllEmployees())
            {
                ProjectAddcheckedListBox.Items.Add(Employee);
            }
        }

        private void CheckEmployeesOnProject(string name)
        {
            foreach (var Employee in EmployeesOnProject.GetEmployeesOnProject(name))
            {
                for (var i = 0; i < ProjectAddcheckedListBox.Items.Count; i++)
                {
                    if (ProjectAddcheckedListBox.Items[i].ToString().GetOIBInCheck() != Employee.ToString().GetOIBInCheck()) continue;
                    ProjectAddcheckedListBox.SetItemChecked(i, true);
                    break;
                }
            }
        }

        private void RemoveUncheckedEmployees()
        {
            foreach (var EmployeeProperty in ProjectAddcheckedListBox.Items)
            {
                if (ProjectAddcheckedListBox.CheckedItems.Contains(EmployeeProperty)) continue;
                if (EmployeesOnProject.IsEmployeeOnProject(EmployeeProperty.ToString().GetOIBInCheck(), OldName))
                {
                    EmployeesOnProject.Remove(EmployeesOnProject.GetRelation(EmployeeProperty.ToString().GetOIBInCheck(), OldName));
                }
            }
        }

        private void AddEmployeesToProject()
        {
            var EmployeesUnchecked = new List<string>();
            foreach (var Oib in CheckedOIBs)
            {
                if (EmployeesOnProject.IsEmployeeOnProject(Oib, OldName)) continue;
                var AddTime = new AddProjectWorkHours(ProjectAddNameTextBox.Text, EmployeesList.FindEmployeeByOIB(Oib).Name);
                AddTime.ShowDialog();
                if (AddTime.HoursToAdd == 0)
                {
                    MessageBox.Show("Upozorenje!", "Zaposlenik ne može raditi ništa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    EmployeesUnchecked.Add(Oib);
                    continue;
                }
                EmployeesOnProject.AddProject(OldName, Oib, AddTime.HoursToAdd);
            }
            UncheckEmployees(EmployeesUnchecked);
        }


        private void UncheckEmployees(IEnumerable<string> OIBList)
        {
            foreach (var OIB in OIBList)
            {
                CheckedOIBs.Remove(OIB);
            }
        }

        private void UpdateProjectName()
        {
            foreach (var Relation in EmployeesOnProject.GetAllRelations())
            {
                if (Relation.ProjectName == OldName)
                {
                    Relation.ProjectName = ProjectAddNameTextBox.Text;
                }
            }
        }

        private bool ErrorCheck()
        {
            if (string.IsNullOrWhiteSpace(ProjectAddNameTextBox.Text))
            {
                MessageBox.Show("Upozorenje!", "Nedostaju podatci!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (CheckedOIBs.Count == 0)
            {
                MessageBox.Show("Upozorenje!", "Projekt mora imati barem jednog zaposlenika!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if (Addition)
            {
                OldName = ProjectAddNameTextBox.Text;
                if (ProjectList.GetProjectByName(OldName) != null)
                {
                    MessageBox.Show("Upozorenje!", "Projekt s istim imenom vec postoji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            else
            {
                if (OldName != ProjectAddNameTextBox.Text && ProjectList.GetProjectByName(ProjectAddNameTextBox.Text) != null)
                {
                    MessageBox.Show("Upozorenje!", "Projekt s istim imenom vec postoji!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }

            if (ProjectAddDateTimeStart.Value <= ProjectAddDateTimeFinisch.Value) return false;
            MessageBox.Show("Upozorenje!", "Projekt se nemože završit prije nego šta se započne!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return true;
        }

        private void ProjectAddBackBttton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProjectAddEmployeeAddButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProjectAddSaveButton_Click(object sender, EventArgs e)
        {
            ProjectAddNameTextBox.Text = ProjectAddNameTextBox.Text.TrimAndRemoveWhiteSpaces().FirstLetterToUpper();

            foreach (var checkedEmployeeItem in ProjectAddcheckedListBox.CheckedItems)
            {
                CheckedOIBs.Add(checkedEmployeeItem.ToString().GetOIBInCheck());
            }

            if (ErrorCheck()) return;

            AddEmployeesToProject();
            if (ErrorCheck()) return;

            RemoveUncheckedEmployees();

            ProjectList.Remove(ProjectList.GetProjectByName(OldName));
            UpdateProjectName();

            ProjectList.AddProject(ProjectAddSaveButton.Text, ProjectAddDateTimeStart.Value, ProjectAddDateTimeFinisch.Value);
            Close();
        }
    }
}
