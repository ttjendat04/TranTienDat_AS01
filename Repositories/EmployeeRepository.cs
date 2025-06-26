using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DataAccessLayer;

namespace Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private List<Employee> employees = DataContext.Employees;

        public List<Employee> GetAll() => employees;
        public Employee GetByUsername(string username) =>
            employees.FirstOrDefault(e => e.UserName.Equals(username, System.StringComparison.OrdinalIgnoreCase));
    }
}
