using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebApplication.Models
{
     public interface IEmployeeInterface
    {
        public Employee GetEmployee(int id);
        public IEnumerable<Employee> GetAllEmployees();
        public Employee Add(Employee employee);

        //Adding the CRUD Functionality to the Repository (IEmployeeInterface)

        public Employee Update(Employee employee);

        public Employee Delete(int id);

    }
}
