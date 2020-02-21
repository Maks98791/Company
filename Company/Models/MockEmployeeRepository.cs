using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Company.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Michael", Surname = "Fold", Email = "michael341@gmail.com", Department = "IT" },
                new Employee() { Id = 1, Name = "Lena", Surname = "Roy", Email = "lene33e@gmail.com", Department = "HR" },
                new Employee() { Id = 1, Name = "Angie", Surname = "Herton", Email = "angie32@gmail.com", Department = "IT" }
            };
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
