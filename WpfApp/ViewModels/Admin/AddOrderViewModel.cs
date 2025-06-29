using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using CustomerBO = BusinessObjects.Customer;


namespace TranTienDatWPF.ViewModels.Admin
{
    public class AddOrderViewModel
    {
        public ObservableCollection<CustomerBO> Customers { get; set; }
        public ObservableCollection<Product> Products { get; set; }
        public ObservableCollection<OrderDetailView> OrderDetails { get; set; }

        public AddOrderViewModel()
        {
            Customers = new ObservableCollection<CustomerBO>(DataAccessLayer.DataContext.Customers);
            Products = new ObservableCollection<Product>(DataAccessLayer.DataContext.Products);
            OrderDetails = new ObservableCollection<OrderDetailView>();
        }

        public void AddToOrder(Product product, int quantity)
        {
            var detail = new OrderDetailView
            {
                ProductID = product.ProductID,
                ProductName = product.ProductName,
                UnitPrice = product.UnitPrice,
                Quantity = quantity,
                Total = product.UnitPrice * quantity
            };
            OrderDetails.Add(detail);
        }
    }
    public class OrderDetailView
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; } = "";
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
    }
}
