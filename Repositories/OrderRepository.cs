using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DataAccessLayer;

namespace Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private List<Order> orders = DataContext.Orders;

        public List<Order> GetAll() => orders;
        public void Add(Order o) => orders.Add(o);
        public void Update(Order o)
        {
            var index = orders.FindIndex(x => x.OrderID == o.OrderID);
            if (index >= 0) orders[index] = o;
        }
        public void Delete(int id) => orders.RemoveAll(o => o.OrderID == id);
        public Order GetById(int id) => orders.FirstOrDefault(o => o.OrderID == id);
    }
}
