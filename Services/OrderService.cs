using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DataAccessLayer;
using Repositories;

namespace Services
{
    public class OrderService
    {
        private readonly OrderRepository repo = new();

        public List<Order> GetAll() => repo.GetAll();
        public void Add(Order o) => repo.Add(o);
        public void Update(Order o) => repo.Update(o);
        public void Delete(int id) => repo.Delete(id);
        public Order GetById(int id) => repo.GetById(id);
        /*public List<(int Month, int Count)> GetOrderStatsByMonth()
        {
            return DataContext.Orders
                .GroupBy(o => o.OrderDate.Month)
                .Select(g => (Month: g.Key, Count: g.Count()))
                .OrderByDescending(x => x.Count)
                .ToList();
        }*/
        public List<(string Month, int Count)> GetOrderStatsByMonth()
        {
            return DataContext.Orders
                .GroupBy(o => new { o.OrderDate.Year, o.OrderDate.Month })
                .Select(g => (
                    Month: $"{g.Key.Month:D2}/{g.Key.Year}",
                    Count: g.Count()
                ))
                .OrderByDescending(x => x.Month)
                .ToList();
        }


    }
}
