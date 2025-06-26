using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace Repositories
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        void Add(Product p);
        void Update(Product p);
        void Delete(int id);
        Product? GetById(int id);
        List<Product> Search(string keyword);
    }
}
