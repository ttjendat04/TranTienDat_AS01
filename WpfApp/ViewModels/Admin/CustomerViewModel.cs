using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using Services;

namespace TranTienDatWPF.ViewModels.Admin
{
    public class CustomerViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Customer> Customers { get; set; }
        private readonly CustomerService service = new();

        public CustomerViewModel()
        {
            Customers = new ObservableCollection<Customer>(service.GetAll());
        }

        public void AddCustomer(Customer c)
        {
            service.Add(c);
            Customers.Add(c);
        }

        public void UpdateCustomer(Customer updatedCustomer)
        {
            service.Update(updatedCustomer);

            var existing = Customers.FirstOrDefault(c => c.CustomerID == updatedCustomer.CustomerID);
            if (existing != null)
            {
                int index = Customers.IndexOf(existing);
                Customers[index] = updatedCustomer;
            }
        }

        public void DeleteCustomer(int id)
        {
            service.Delete(id);
            var item = Customers.FirstOrDefault(x => x.CustomerID == id);
            if (item != null) Customers.Remove(item);
        }

        public void Search(string keyword)
        {
            var result = service.Search(keyword);
            Customers.Clear();
            foreach (var c in result) Customers.Add(c);
            /*Customers.Clear();
            foreach (var c in service.Search(keyword)) Customers.Add(c);*/

        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
