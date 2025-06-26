using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using Repositories;

namespace Services
{
    public class EmployeeService
    {
        private readonly EmployeeRepository repo = new();

        public List<Employee> GetAll() => repo.GetAll();
        public Employee GetByUsername(string username) => repo.GetByUsername(username);
    
    }
}
