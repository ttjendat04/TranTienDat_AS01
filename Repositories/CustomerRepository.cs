using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DataAccessLayer;

namespace Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        
            private static CustomerRepository _instance;
            private List<Customer> customers;

            private CustomerRepository()
            {
                customers = DataContext.Customers;
            }

            public static CustomerRepository Instance => _instance ??= new CustomerRepository();

            public List<Customer> GetAll() => customers;

            public void Add(Customer c) => customers.Add(c);

            public void Update(Customer c)
            {
                var index = customers.FindIndex(x => x.CustomerID == c.CustomerID);
                if (index >= 0) customers[index] = c;
            }

            public void Delete(int id) => customers.RemoveAll(c => c.CustomerID == id);

            public Customer GetById(int id) => customers.FirstOrDefault(c => c.CustomerID == id);

            public List<Customer> Search(string keyword) =>
                customers.Where(c => c.CompanyName.Contains(keyword, System.StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }



