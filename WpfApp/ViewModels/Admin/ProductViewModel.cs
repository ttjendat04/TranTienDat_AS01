﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using Services;

namespace TranTienDatWPF.ViewModels.Admin
{
    public class ProductViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Product> Products { get; set; }
        private readonly ProductService service = new();

        public ProductViewModel()
        {
            Products = new ObservableCollection<Product>(service.GetAll());
        }

        public void AddProduct(Product p)
        {
            service.Add(p);
            Products.Add(p);
        }

        public void UpdateProduct(Product p)
        {
            service.Update(p);
            var old = Products.FirstOrDefault(x => x.ProductID == p.ProductID);
            if (old != null)
            {
                int idx = Products.IndexOf(old);
                Products[idx] = p;
            }
        }


        public void DeleteProduct(int id)
        {
            service.Delete(id);
            var item = Products.FirstOrDefault(x => x.ProductID == id);
            if (item != null) Products.Remove(item);
        }

        public void Search(string keyword)
        {
            Products.Clear();
            foreach (var p in service.Search(keyword))
            {
                Products.Add(p);
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
