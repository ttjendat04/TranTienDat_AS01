using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using Repositories;

namespace Services
{
    public class ProductService
    {
        private readonly ProductRepository repo = new();

        public List<Product> GetAll() => repo.GetAll();
        public void Add(Product p) => repo.Add(p);
        public void Update(Product p) => repo.Update(p);
        public void Delete(int id) => repo.Delete(id);
        public Product GetById(int id) => repo.GetById(id);
        public List<Product> Search(string keyword) => repo.Search(keyword);
    }
}
