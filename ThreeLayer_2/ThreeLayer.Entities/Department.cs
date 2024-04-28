using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeLayer.Entities
{
    [Serializable]
    public class Department 
    {
        public string departmentName { get; set; }
        public List<Employee> staff { get; set; }
        public int id;

        public Department()
        {
            departmentName = "";
            staff = new List<Employee>();
        }
        public Department(string name)
        {
            departmentName = name;
            staff = new List<Employee>();
        }
        public Department(string name, List<Employee> staff)
        {
            departmentName = name;
            this.staff = staff;
        }
        [Serializable]
        public struct Employee
        {
            public string firstName;
            public string lastName;
            public string position;
            public int id;
            public Employee()
            {
                firstName = "";
                lastName = "";
                position = "";
            }
            public Employee(string firstName, string lastName, string position)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.position = position;
            }
            public Employee(Employee employee)
            {
                firstName = employee.firstName;
                lastName = employee.lastName;
                position = employee.position;
            }
            public override string ToString()
            {
                return $"{firstName} {lastName}, {position}";
            }
        }

        public static explicit operator Department(String departmentInfo)
        {
            return new Department(departmentInfo);
        }
        public override string ToString()
        {
            return $"{departmentName}";
        }


        public void AddEmployee(Employee employee)
        {
            staff.Add(employee);
        }
    }
}
