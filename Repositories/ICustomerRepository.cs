using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace Repositories
{
    public interface ICustomerRepository
    {
        List<Customer> GetAll();
        void Add(Customer c);
        void Update(Customer c);
        void Delete(int id);
        Customer GetById(int id);
        List<Customer> Search(string keyword);
    }
}
