using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DataAccessLayer;

namespace Repositories
{
    public class ProductRepository : IProductRepository
    {
        private static ProductRepository _instance;
        private List<Product> products = DataContext.Products;

        public List<Product> GetAll() => products;
        public void Add(Product p) => products.Add(p);
        public void Update(Product p)
        {
            var index = products.FindIndex(x => x.ProductID == p.ProductID);
            if (index >= 0) products[index] = p;
        }
        public void Delete(int id) => products.RemoveAll(p => p.ProductID == id);
        public Product? GetById(int id) => products.FirstOrDefault(p => p.ProductID == id);
        public List<Product> Search(string keyword) =>
            products.Where(p => p.ProductName.Contains(keyword, System.StringComparison.OrdinalIgnoreCase)).ToList();
    }
}
