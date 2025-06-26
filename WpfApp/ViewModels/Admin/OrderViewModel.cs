using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace TranTienDatWPF.ViewModels.Admin
{
    public class OrderViewModel
    {
        public ObservableCollection<Order> Orders { get; set; } = new();
        public void AddOrder(Order order) => Orders.Add(order);
    }
}
