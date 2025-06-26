using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using Repositories;

namespace Services
{
    public class CustomerService
    {
        private readonly CustomerRepository _repo = CustomerRepository.Instance;

        public List<Customer> GetAll() => _repo.GetAll();
        public void Add(Customer c) => _repo.Add(c);

        public void Delete(int id) => _repo.Delete(id);
        public void Update(Customer c) => _repo.Update(c);
        public List<Customer> Search(string keyword) => _repo.Search(keyword);
        public Customer? GetByPhone(string phone)
        {
            return _repo.GetByPhone(phone);
        }

    }
}
