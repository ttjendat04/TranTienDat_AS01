using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace Repositories
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAll();
        Employee GetByUsername(string username);
    }
}
