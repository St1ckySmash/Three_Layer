using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeLayer.Entities;

namespace ThreeLayer.DAL
{
    public interface IOrganizationDB
    {
        //Department
        //Добавление по объекту департамента
        void AddDepartment(Department department);
        //Удаление по ID департамента
        void DeleteDepartment(int departmentID);
        //Добавление по ID департамента и объекту работника
        void AddEmployee(int departmentID, Department.Employee employee);
        //Удаление по ID работника
        void DeleteEmployee(int departmentID, int employeeID);
        //Поиск департамента по ID департамента
        Department? FindDepartment(string departmentName);
        List<Department.Employee>? FindEmployees(int departmentID, string arg, string mode);
        List<Department>? FindEmployees(string arg, string mode);
        public List<Department.Employee> FindDepartmentEmployees(int departmentID);
        //Getters
        IEnumerable GetDepartmentEmployees(int departmentID);
        IEnumerable GetAllEmployees();
        IEnumerable GetAllDepartments();
        void SaveOrganizationDB();
    }
}
