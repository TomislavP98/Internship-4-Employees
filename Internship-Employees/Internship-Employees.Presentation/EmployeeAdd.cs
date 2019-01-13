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
using Internship_Employees.Data.Models;
using Internship_Employees.Domain.Repositories;
using Internship_Employees.Infrastructure.Extensions;



namespace Internship_Employees.Presentation
{
    public partial class EmployeeAdd : Form
    {
        public string OldOIB { get; set; }
        public bool Addition { get; set; }

        public  EmployeeAdd()
        {
            InitializeComponent();
            EmployeeAddDateTimePicker.MaxDate = DateTime.Now.Subtract(new TimeSpan(365 * 18 + 4, 0, 0, 0));
            RefreshListBox();
            RefreshComboBox();
            Addition = true;
        }

        private void EmployeAddBackButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Jeste li sigurni da zelite izbrisati odabrane stavke?", "Oprez!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                this.Close();
            }
        }

        public EmployeeAdd(Employees Added)
        {
            OldOIB= Added.OIB;
            Addition = false;

            InitializeComponent();
            EmployeAddNameTextbox.Text = Added.Name;
            EmployeeAddSurnameTextbox.Text = Added.Surname;
            EmployeeAddDateTimePicker.Value = Added.BirthDay;
            EmployeeAddDateTimePicker.MaxDate = DateTime.Now.Subtract(new TimeSpan(365 * 18 + 4, 0, 0, 0));
            EmployeeAddOIBTextbox.Text = Added.OIB;
            RefreshComboBox();
            EmployeeAddcomboBox.Text = Added.Rank.ToString();
            RefreshListBox();
            CheckProjectsDoneByEmployee(Added.OIB);
        }

        private void RefreshListBox()
        {
            EmployeePositioncheckedListBox.Items.Clear();
            foreach (var Project in ProjectList.AquireProjects())
            {
                EmployeePositioncheckedListBox.Items.Add(Project);
            }
        }

        private void CheckProjectsDoneByEmployee(string Oib)
        {
            foreach (var Project in EmployeesOnProject.GetProjectsByEmployee(Oib))
            {
                for (var i = 0; i < EmployeePositioncheckedListBox.Items.Count; i++)
                {
                    if (EmployeePositioncheckedListBox.Items[i].ToString().GetProjectNameInCheck() != Project.ToString().GetProjectNameInCheck()) continue;
                    EmployeePositioncheckedListBox.SetItemChecked(i, true);
                    break;
                }
            }
        }
        private void RefreshComboBox()
        {
            var Positions = Enum.GetNames(typeof(CompanyPositions));
            foreach (var Position in Positions)
            {
                EmployeeAddcomboBox.Items.Add(Position);
            }
        }

        private void EmployeeAddAddButton_Click(object sender, EventArgs e)
        {
            if (ErrorCheck()) return;

            EmployeAddNameTextbox.Text = EmployeAddNameTextbox.Text.TrimAndRemoveWhiteSpaces().AllFirstLettersToUpper();
            EmployeeAddSurnameTextbox.Text = EmployeeAddSurnameTextbox.Text.TrimAndRemoveWhiteSpaces().AllFirstLettersToUpper();

            var CheckedNames = new List<string>();
            foreach (var ProjectProperties in EmployeePositioncheckedListBox.CheckedItems)
            {
                CheckedNames.Add(ProjectProperties.ToString().GetProjectNameInCheck());
            }

            if (!RemoveUncheckedProjects()) return;
            AddProjectsToEmployee(CheckedNames);

            EmployeesList.EmployeeDelete(EmployeesList.FindEmployeeByOIB(OldOIB));
            UpdateOIB();

            EmployeesList.AddEmployee(EmployeAddNameTextbox.Text, EmployeeAddSurnameTextbox.Text, EmployeeAddDateTimePicker.Value, EmployeeAddOIBTextbox.Text,
                (CompanyPositions)Enum.Parse(typeof(CompanyPositions), EmployeeAddcomboBox.Text));

            Close();
        }

        private void UpdateOIB()
        {
            foreach (var relation in EmployeesOnProject.GetAllRelations())
            {
                if (relation.OIB == OldOIB)
                {
                    relation.OIB = EmployeeAddOIBTextbox.Text;
                }
            }
        }

        private bool RemoveUncheckedProjects()
        {
            foreach (var ProjectProperty in EmployeePositioncheckedListBox.Items)
            {
                if (EmployeePositioncheckedListBox.CheckedItems.Contains(ProjectProperty)) continue;
                if (!EmployeesOnProject.IsEmployeeOnProject(OldOIB, ProjectProperty.ToString().GetProjectNameInCheck()) )continue;
                if (EmployeesOnProject.TryRemove(EmployeesOnProject.GetRelation(OldOIB, ProjectProperty.ToString().GetProjectNameInCheck())))
                    continue;
                EmployeeDeleteError LastEmp = new EmployeeDeleteError();
                LastEmp.ShowDialog();
                return false;
            }
            return true;
        }

        private void AddProjectsToEmployee(IEnumerable<string> SourceProjectList)
        {
            foreach (var Name in SourceProjectList)
            {
                if (EmployeesOnProject.IsEmployeeOnProject(OldOIB, Name)) continue;
                var AddTime = new AddEmployeeWorkHours(Name, EmployeAddNameTextbox.Text);
                AddTime.ShowDialog();
                if (AddTime.HoursToAdd == 0)
                {
                    MessageBox.Show("Upozorenje!", "Nemoze zaposlenik ne radit ništa!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue;
                }
                EmployeesOnProject.AddProject(Name, OldOIB, AddTime.HoursToAdd);
            }

        }

        private bool ErrorCheck()
        {
            if (string.IsNullOrWhiteSpace(EmployeAddNameTextbox.Text) ||
                string.IsNullOrWhiteSpace(EmployeeAddSurnameTextbox.Text) ||
                string.IsNullOrWhiteSpace(EmployeeAddOIBTextbox.Text) ||
                string.IsNullOrWhiteSpace(EmployeeAddcomboBox.Text))
            {
                MessageBox.Show("Upozorenje!", "Nedostaju podatci!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if (!EmployeeAddOIBTextbox.Text.OIBValidation())
            {
                MessageBox.Show("Upozorenje!", "Nije važeči OIB!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if (Addition)
            {
                OldOIB = EmployeeAddOIBTextbox.Text;
                if (EmployeesList.FindEmployeeByOIB(OldOIB) == null) return false;
                MessageBox.Show("Upozorenje!", "Već postoji zaposlenik s istim OIB-om!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                if (OldOIB == EmployeeAddOIBTextbox.Text || EmployeesList.FindEmployeeByOIB(EmployeeAddOIBTextbox.Text) == null) return false;
                MessageBox.Show("Upozorenje!", "Već postoji zaposlenik s istim OIB-om!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }
    }
}
