using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.CodeDom.Compiler;
using System.Text;
using ThreeLayer.Entities;
using ThreeLayer.BLL;
using ThreeLayer.Common;

namespace ThreeLayer.PL
{
    public partial class Form1 : Form
    {
        IOrganizationLogic logic;
        Department selectedDepartment;
        Department.Employee selectedEmployee;
        public string PersonParameter
        {
            get; set;
        }
        public string OrganizationParameter
        {
            get; set;
        }
        IEnumerable departments;

        public Form1()
        {
            InitializeComponent();
            logic = DependencyResolver.OrganizationLogic;

            DepartmentList.SelectedIndex = -1;
            EmployeeList.SelectedIndex = -1;

            departments = logic.GetAllDepartments();
            foreach (Department department in departments)
            {
                DepartmentList.Items.Add(department);
            }
            DepartmentList.Sorted = true;
            EmployeeList.Sorted = true;
        }
        //================================================================================
        //DEPARTMENT
        private void Department_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeList.Items.Clear();
            if (DepartmentList.SelectedIndex > -1)
            {
                selectedDepartment = (Department)DepartmentList.SelectedItem;
                foreach (Department.Employee employee in selectedDepartment.staff)
                {
                    EmployeeList.Items.Add(employee);
                }
            }
        }
        private void AddDepartmentButton_Click(object sender, EventArgs e)
        {
            if (AddDepartmentTextBox.Text == "")
            {
                return;
            }
            foreach (Department dep in departments)
            {
                if (dep.departmentName == AddDepartmentTextBox.Text)
                {
                    MessageBox.Show("Такой отдел уже существует!", "Error");
                    return;
                }
            }
            Department addedDepartment = new Department(AddDepartmentTextBox.Text);
            DepartmentList.Items.Add(addedDepartment);
            AddDepartmentTextBox.Clear();
            logic.AddDepartment(addedDepartment);
        }
        private void DeleteDepartmentButton_Click(object sender, EventArgs e)
        {
            if (DepartmentList.SelectedIndex < 0)
            {
                MessageBox.Show("Не выбран отдел", "Error");
                return;
            }
            DepartmentList.Items.Remove(selectedDepartment);
            DepartmentSearch.Items.Remove(selectedDepartment);
            logic.DeleteDepartment(selectedDepartment.id);

        }
        //================================================================================
        //EMPLOYEE
        private void EmployeeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EmployeeList.SelectedIndex < 0)
            {
                return;
            }
            selectedEmployee = (Department.Employee)EmployeeList.SelectedItem;
        }
        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FirstNameTextBox.Text))
            {
                MessageBox.Show("Не введено имя!", "Error");
                return;
            }
            if (string.IsNullOrEmpty(LastNameTextBox.Text))
            {
                MessageBox.Show("Не введена фамилия!", "Error");
                return;
            }
            if (string.IsNullOrEmpty(PositionTextBox.Text))
            {
                MessageBox.Show("Не введена должность!", "Error");
                return;
            }
            if (DepartmentList.SelectedIndex < 0)
            {
                MessageBox.Show("Не выбран отдел!", "Error");
                return;
            }

            Department.Employee addedEmployee =
                new Department.Employee(FirstNameTextBox.Text, LastNameTextBox.Text, PositionTextBox.Text);
            EmployeeList.Items.Add(addedEmployee);
            FirstNameTextBox.Clear();
            LastNameTextBox.Clear();
            PositionTextBox.Clear();
            logic.AddEmployee(selectedDepartment.id, addedEmployee);
            SearchButton_Click(sender, e);
        }
        private void DeleteEmployeeButton_Click(object sender, EventArgs e)
        {
            if (EmployeeList.SelectedIndex < 0)
            {
                MessageBox.Show("Не выбран работник!", "Error");
                return;
            }
            EmployeeList.Items.Remove(selectedEmployee);
            logic.DeleteEmployee(selectedDepartment.id, selectedEmployee.id);
            SearchButton_Click(sender, e);
        }
        //================================================================================
        //SEARCH

        //TODO: ДОБАВИТЬ В СПИСОК ИЗ ПОЛУЧЕННОГО
        private void SearchButton_Click(object sender, EventArgs e)
        {
            DepartmentSearch.Items.Clear();
            EmployeesSearch.Items.Clear();
            string searchArgument = EmployeeFieldSearchTextBox.Text;
            switch (OrganizationParameter)
            {
                case "По отделу":
                    List<Department.Employee> tempEmployees = logic.FindEmployees(selectedDepartment.id, searchArgument, PersonParameter);
                    foreach (Department.Employee man in tempEmployees)
                    {
                        EmployeesSearch.Items.Add(man);
                    }
                    break;
                case "По организации":
                    List<Department> tempDepartments = logic.FindEmployees(searchArgument, PersonParameter);
                    foreach (Department department in tempDepartments)
                    {
                        DepartmentSearch.Items.Add(department);
                        foreach (Department.Employee man in department.staff)
                        {
                            EmployeesSearch.Items.Add(man);
                        }
                    }
                    break;
                default:
                    break;
            }
        }
        private void DepartmentSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeesSearch.Items.Clear();
            if (DepartmentSearch.SelectedIndex > -1)
            {
                Department selectedDepartment = (Department)DepartmentSearch.SelectedItem;
                foreach (Department.Employee man in selectedDepartment.staff)
                {
                    EmployeesSearch.Items.Add(man);
                }
            }
        }
        //================================================================================
        //SAVING
        private void SaveButton_Click(object sender, EventArgs e)
        {
            logic.SaveData();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Сохранить изменения?", "Organization DB",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                logic.SaveData();
            }
        }

        private void SearchParameters_Click(object sender, EventArgs e)
        {
            Form2 searchParameters = new Form2(this);
            searchParameters.Show();
        }
        private void FirstNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LastNameTextBox.Focus();
            }
        }
        private void LastNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PositionTextBox.Focus();
            }
        }
        private void PositionTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddEmployeeButton_Click(sender, e);
            }
        }
        private void EmployeeFieldSearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchButton_Click(sender, e);
            }
        }
        private void AddDepartmentTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddDepartmentButton_Click(sender, e);
            }
        }
    }
}
