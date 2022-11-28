using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebApplication.Models
{
    public class MockEmployee : IEmployeeInterface
    {
        private List<Employee> _employeeList;

        public MockEmployee()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { id = 18, Name = "Vikram"},
                new Employee() { id = 11, Name = "Krithika"},
                new Employee() { id = 21, Name = "Jeeva"},
                new Employee() { id = 24, Name = "Yuvaraj"},
                new Employee() { id = 2, Name = "Luvika"},
                new Employee() { id = 14, Name = "Bharath"},
                new Employee() { id = 1802, Name = "Samiulla"}
            };
        }

        public Employee Add(Employee employee)
        {
            employee.id =  _employeeList.Max(makeid => makeid.id) + 1;
            _employeeList.Add(employee);
            return employee;
        }

        public Employee Delete(int id)
        {
            Employee employee =  _employeeList.FirstOrDefault(e => e.id == id);
            if (employee != null)
            {
                _employeeList.Remove(employee);
            }
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.id == id);
        }

        public Employee Update(Employee employee)
        {
            Employee newEmployee = _employeeList.FirstOrDefault(e => e.id == employee.id);
            if (newEmployee != null)
            {
                newEmployee.Name = employee.Name;
            }
            return newEmployee;
        }
    }
}
