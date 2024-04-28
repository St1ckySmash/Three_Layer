using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeLayer.Entities;

namespace ThreeLayer.BLL
{
    public interface IOrganizationLogic
    {
        void SaveData();
        void AddDepartment(string departmentName);
        void AddDepartment(Department department);
        void DeleteDepartment(int departmentID);
        void AddEmployee(int departmentID, Department.Employee employee);
        void DeleteEmployee(int departmentID, int employeeID);
        List<Department.Employee>? FindEmployees(int departmentID, string arg, string mode);
        List<Department>? FindEmployees(string arg, string mode);
        List<Department.Employee> FindDepartmentEmployees(int departmentID);
        IEnumerable GetDepartmentEmployees(int departmentID);
        IEnumerable GetAllEmployees();
        IEnumerable GetAllDepartments();
    }
}
