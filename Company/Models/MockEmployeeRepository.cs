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
                new Employee() { Id = 1, Name = "Michael", Surname = "Fold", Email = "michael341@gmail.com", Department = Department.HR },
                new Employee() { Id = 2, Name = "Lena", Surname = "Roy", Email = "lene33e@gmail.com", Department = Department.IT },
                new Employee() { Id = 3, Name = "Angie", Surname = "Herton", Email = "angie32@gmail.com", Department = Department.None }
            };
        }

        public Employee AddEmployee(Employee employee)
        {
            employee.Id = _employeeList.Max(e => e.Id) + 1;
            _employeeList.Add(employee);
            return employee;
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
