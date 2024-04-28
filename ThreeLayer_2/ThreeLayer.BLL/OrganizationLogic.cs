using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeLayer.Entities;
using ThreeLayer.DAL;
using System.Runtime.Serialization.Formatters.Binary;

namespace ThreeLayer.BLL
{
    public class OrganizationLogic : IOrganizationLogic
    {
        private IOrganizationDB organizationDB;
        public OrganizationLogic(IOrganizationDB organizationDB)
        {
            this.organizationDB = organizationDB;
        }
        public void SaveData()
        {
            organizationDB.SaveOrganizationDB();
        }
        public void AddDepartment(string departmentName)
        {
            Department department = new Department(departmentName);
            organizationDB.AddDepartment(department);
        }
        public void AddDepartment(Department department)
        {
            organizationDB.AddDepartment(department);
        }
        public void DeleteDepartment(int departmentID)
        {
            organizationDB.DeleteDepartment(departmentID);
        }
        public void AddEmployee(int departmentID, Department.Employee employee)
        {
            organizationDB.AddEmployee(departmentID, employee);
        }
        public void DeleteEmployee(int departmentID, int employeeID)
        {
            organizationDB.DeleteEmployee(departmentID, employeeID);
        }
        public List<Department.Employee>? FindEmployees(int departmentID, string arg, string mode)
        {
            return organizationDB.FindEmployees(departmentID, arg, mode);
        }
        public List<Department>? FindEmployees(string arg, string mode)
        {
            return organizationDB.FindEmployees(arg, mode);
        }
        public List<Department.Employee> FindDepartmentEmployees(int departmentID)
        {
            return organizationDB.FindDepartmentEmployees(departmentID);
        }
        public IEnumerable GetDepartmentEmployees(int departmentID)
        {
            return organizationDB.GetDepartmentEmployees(departmentID);
        }
        public IEnumerable GetAllEmployees()
        {
            return organizationDB.GetAllEmployees();
        }
        public IEnumerable GetAllDepartments()
        {
            return organizationDB.GetAllDepartments();
        }
    }
}
