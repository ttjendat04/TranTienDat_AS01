using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranTienDatWPF.ViewModels.Customer
{
    public class CustomerOrderViewModel
    {
        public ObservableCollection<OrderDisplay> Orders { get; set; }

        public CustomerOrderViewModel(int customerId)
        {
            Orders = new ObservableCollection<OrderDisplay>(
                DataAccessLayer.DataContext.Orders
                .Where(o => o.CustomerID == customerId)
                .Select(o => new OrderDisplay
                {
                    OrderID = o.OrderID,
                    OrderDate = o.OrderDate,
                    TotalAmount = o.OrderDetails.Sum(d =>
                        d.UnitPrice * d.Quantity * (decimal)(1 - d.Discount))
                }));
        }
    }

    public class OrderDisplay
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
    }
}


