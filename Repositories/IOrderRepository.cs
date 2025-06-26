using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace Repositories
{
    public interface IOrderRepository
    {
        List<Order> GetAll();
        void Add(Order o);
        void Update(Order o);
        void Delete(int id);
        Order GetById(int id);
    }
}
