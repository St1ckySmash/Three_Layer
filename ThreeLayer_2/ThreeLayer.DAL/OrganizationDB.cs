using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ThreeLayer.Entities;

namespace ThreeLayer.DAL
{
    [Serializable]
    public class OrganizationDB : IOrganizationDB
    {
        private Hashtable departments;
        private int departmentID;
        private int employeeID;

        public OrganizationDB() //конструктор класса
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream data = new FileStream("data.dat", FileMode.OpenOrCreate);
            FileStream IDs = new FileStream("ID.dat", FileMode.OpenOrCreate);
            if (data.Length == 0) //файл пуст, создаём новую базу
            {
                departments = new Hashtable();
                departmentID = 0;
                employeeID = 0;
            }
            else // иначе выполняем десериализацию
            {
                departments = (Hashtable)formatter.Deserialize(data);
                departmentID = (int)formatter.Deserialize(IDs);
                employeeID = (int)formatter.Deserialize(IDs);
            }
            IDs.Close();
            data.Close();
        }
        ~OrganizationDB()
        {
            SaveOrganizationDB();
        }
        public void SaveOrganizationDB()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream data = new FileStream("data.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(data, departments);
            }
            using (FileStream IDs = new FileStream("ID.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(IDs, departmentID);
                formatter.Serialize(IDs, employeeID);
            }
        }
        //================================================================================
        //DEPARTMENTS
        public void AddDepartment(Department department)
        {
            departmentID++;
            department.id = departmentID;
            departments.Add(departmentID, department);
        }

        public void DeleteDepartment(int departmentID)
        {
            departments.Remove(departmentID);
        }
        //================================================================================
        //EMPLOYEE
        public void AddEmployee(int departmentID, Department.Employee employee)
        {
            employeeID++;
            employee.id = employeeID;
            ((Department)departments[departmentID]).AddEmployee(employee);
        }
        public void DeleteEmployee(int departmentID, int employeeID)
        {
            Department temp = (Department)departments[departmentID];
            for (int i = 0; i < temp.staff.Count; i++)
            {
                if (temp.staff[i].id == employeeID)
                {
                    temp.staff.RemoveAt(i);
                    return;
                }
            }
        }
        //================================================================================
        //SEARCH
        public Department? FindDepartment(string departmentName)
        {
            ICollection keys = departments.Keys;
            foreach (int index in keys)
            {
                if (((Department)departments[index]).departmentName == departmentName)
                {
                    return ((Department)departments[index]);
                }
            }
            return null;
        }
        public List<Department.Employee> FindEmployees(int departmentID, string arg, string mode)
        {
            List<Department.Employee> temp = new List<Department.Employee>();
            switch (mode)
            {
                case "Имя":
                    foreach (Department.Employee man in ((Department)departments[departmentID]).staff)
                    {
                        if (man.firstName == arg)
                        {
                            temp.Add(man);
                        }
                    }
                    break;
                case "Фамилия":
                    foreach (Department.Employee man in ((Department)departments[departmentID]).staff)
                    {
                        if (man.lastName == arg)
                        {
                            temp.Add(man);
                        }
                    }
                    break;
                case "Должность":
                    foreach (Department.Employee man in ((Department)departments[departmentID]).staff)
                    {
                        if (man.position == arg)
                        {
                            temp.Add(man);
                        }
                    }
                    break;
            }
            return temp;
        }
        public List<Department> FindEmployees(string arg, string mode)
        {
            List<Department> result = new List<Department>();
            Department temp;
            switch (mode)
            {
                case "По имени":
                    foreach (Department department in departments.Values)
                    {
                        temp = new Department();
                        temp.departmentName = department.departmentName;
                        foreach (Department.Employee man in department.staff)
                        {
                            if (man.firstName == arg)
                            {
                                temp.staff.Add(man);
                            }
                        }
                        if (temp.staff.Count != 0)
                        {
                            result.Add(temp);
                        }
                    }
                    break;
                case "По фамилии":
                    foreach (Department department in departments.Values)
                    {
                        temp = new Department();
                        temp.departmentName = department.departmentName;
                        foreach (Department.Employee man in department.staff)
                        {
                            if (man.lastName == arg)
                            {
                                temp.staff.Add(man);
                            }
                        }
                        if (temp.staff.Count != 0)
                        {
                            result.Add(temp);
                        }
                    }
                    break;
                case "По должности":
                    foreach (Department department in departments.Values)
                    {
                        temp = new Department();
                        temp.departmentName = department.departmentName;
                        foreach (Department.Employee man in department.staff)
                        {
                            if (man.position == arg)
                            {
                                temp.staff.Add(man);
                            }
                        }
                        if (temp.staff.Count != 0)
                        {
                            result.Add(temp);
                        }
                    }
                    break;
            }
            return result;
        }
        public List<Department.Employee>? FindDepartmentEmployees(int departmentID)
        {
            ICollection keys = departments.Keys;
            foreach (int index in keys)
            {
                if (index == departmentID)
                {
                    return ((Department)departments[index]).staff;
                }
            }
            return null;
        }
        //================================================================================
        //GETTERS
        public IEnumerable GetDepartmentEmployees(int departmentID)
        {
            return ((Department)departments[departmentID]).staff;
        }
        public IEnumerable GetAllEmployees()
        {
            List<Department.Employee> employees = new List<Department.Employee>();
            ICollection keys = departments.Keys;
            foreach (int index in keys)
            {
                employees.AddRange(((Department)departments[index]).staff);
            }
            return employees;
        }
        public IEnumerable GetAllDepartments()
        {
            return departments.Values;
        }
    }
}
