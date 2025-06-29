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
using CustomerBO = BusinessObjects.Customer;


namespace TranTienDatWPF.ViewModels.Admin
{
    public class CustomerViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<CustomerBO> Customers { get; set; }
        private readonly CustomerService service = new();

        public CustomerViewModel()
        {
            Customers = new ObservableCollection<CustomerBO>(service.GetAll());
        }

        public void AddCustomer(CustomerBO c)
        {
            service.Add(c);
            Customers.Add(c);
        }

        public void UpdateCustomer(CustomerBO updatedCustomer)
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
