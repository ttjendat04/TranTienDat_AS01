using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataAccessLayer
{
    public class DataContext
    {
        public static List<Customer> Customers = new List<Customer>() { 
        new Customer { CustomerID = 1, CompanyName = "Zalo", ContactName = "Alice", ContactTitle = "Manager", Address = "123 Main St", Phone = "1234567890", Password="123" },
            new Customer { CustomerID = 2, CompanyName = "Facebook", ContactName = "Bob", ContactTitle = "Director", Address = "456 Elm St", Phone = "9876543210" },
            new Customer { CustomerID = 3, CompanyName = "FPT Software", ContactName = "Charlie", ContactTitle = "CEO", Address = "789 Oak St", Phone = "555-555-5555" },
            new Customer { CustomerID = 4, CompanyName = "Momo", ContactName = "Micheal", ContactTitle = "Manager", Address = "613 Korea St", Phone = "123-456-78070" },
            new Customer { CustomerID = 5, CompanyName = "Elca", ContactName = "Elon Musk", ContactTitle = "Director", Address = "456 Ank St", Phone = "987-654-3610" },
            new Customer { CustomerID = 6, CompanyName = "Net Company", ContactName = "Trump", ContactTitle = "CEO", Address = "789 One St", Phone = "555-555-5545" },
            new Customer { CustomerID = 7, CompanyName = "Youtube", ContactName = "Putin", ContactTitle = "Manager", Address = "123 FPT St", Phone = "123-456-7810" },
            new Customer { CustomerID = 8, CompanyName = "Instagram", ContactName = "Lisa", ContactTitle = "Director", Address = "456 BAC St", Phone = "987-654-3210" },
            new Customer { CustomerID = 9, CompanyName = "Vieon", ContactName = "Rose", ContactTitle = "CEO", Address = "789 Oak St", Phone = "555-555-5556" },
            new Customer { CustomerID = 10, CompanyName = "Google", ContactName = "Karina", ContactTitle = "Manager", Address = "123 FW St", Phone = "123-56-7890" },

        };

        public static List<Employee> Employees = new() {
            new Employee { EmployeeID = 1, Name = "John", UserName = "admin", Password = "123", JobTitle = "Manager",
                BirthDate = new DateTime(1990, 1, 1), HireDate = new DateTime(2020, 1, 1), Address = "HN" },
            new Employee { EmployeeID = 2, Name = "Anna", UserName = "anna", Password = "abc", JobTitle = "Sales",
                BirthDate = new DateTime(1992, 5, 10), HireDate = new DateTime(2021, 6, 15), Address = "HCM" },
            new Employee { EmployeeID = 3, Name = "Mina", UserName = "mina", Password = "123", JobTitle = "CEO",
                BirthDate = new DateTime(1999, 8, 1), HireDate = new DateTime(2018, 8, 12), Address = "HN" },
            new Employee { EmployeeID = 4, Name = "Lucy", UserName = "lucy", Password = "abc", JobTitle = "Sales",
                BirthDate = new DateTime(1994, 12, 12), HireDate = new DateTime(2021, 8, 16), Address = "HCM" },
            new Employee { EmployeeID = 5, Name = "Daniel", UserName = "daniel", Password = "123", JobTitle = "Manager",
                BirthDate = new DateTime(1995, 8, 1), HireDate = new DateTime(2020, 4, 8), Address = "HN" },
            new Employee { EmployeeID = 6, Name = "Seth", UserName = "seth", Password = "abc", JobTitle = "Sales",
                BirthDate = new DateTime(1993, 9, 10), HireDate = new DateTime(2021, 6, 16), Address = "HCM" },
            new Employee { EmployeeID = 7, Name = "Dolp", UserName = "dolp", Password = "123", JobTitle = "Manager",
                BirthDate = new DateTime(1992, 1, 19), HireDate = new DateTime(2020, 1, 17), Address = "HN" },
            new Employee { EmployeeID = 8, Name = "Cesaro", UserName = "cesaro", Password = "abc", JobTitle = "Sales",
                BirthDate = new DateTime(1998, 5, 17), HireDate = new DateTime(2021, 6, 19), Address = "HCM" }
        };

        public static List<Category> Categories = new() {
            new Category { CategoryID = 1, CategoryName = "Furniture", Description = "Classroom chairs", Picture = null },
            new Category { CategoryID = 2, CategoryName = "Electronics", Description = "Smart boards", Picture = null },
            new Category { CategoryID = 3, CategoryName = "Smartphone", Description = " IPhone", Picture = null },
            new Category { CategoryID = 4, CategoryName = "Electronics", Description = "Smart Door", Picture = null },
            new Category { CategoryID = 5, CategoryName = "Furniture", Description = "Picure ", Picture = null },
            new Category { CategoryID = 6, CategoryName = "Smartphone", Description = "Samsung", Picture = null }
        };

        public static List<Product> Products = new() {
            new Product { ProductID = 1, ProductName = "Wooden Desk", SupplierID = 1, CategoryID = 1, QuantityPerUnit = "1 unit",
                UnitPrice = 2000000, UnitsInStock = 100, UnitsOnOrder = 10, ReorderLevel = 5, Discontinued = false },
            new Product { ProductID = 2, ProductName = "Smart Board", SupplierID = 2, CategoryID = 2, QuantityPerUnit = "1 panel",
                UnitPrice = 15000000, UnitsInStock = 20, UnitsOnOrder = 5, ReorderLevel = 2, Discontinued = false },
            new Product { ProductID = 3, ProductName = "Wooden Desk", SupplierID = 3, CategoryID = 1, QuantityPerUnit = "2 unit",
                UnitPrice = 2200000, UnitsInStock = 120, UnitsOnOrder = 10, ReorderLevel = 4, Discontinued = false },
            new Product { ProductID = 4, ProductName = "Smart Board", SupplierID = 4, CategoryID = 2, QuantityPerUnit = "2 panel",
                UnitPrice = 16000000, UnitsInStock = 200, UnitsOnOrder = 5, ReorderLevel = 3, Discontinued = false },
            new Product { ProductID = 5, ProductName = "Wooden Desk", SupplierID = 5, CategoryID = 1, QuantityPerUnit = "3 unit",
                UnitPrice = 2700000, UnitsInStock = 150, UnitsOnOrder = 10, ReorderLevel = 7, Discontinued = false },
            new Product { ProductID = 6, ProductName = "Smart Board", SupplierID = 6, CategoryID = 2, QuantityPerUnit = "3 panel",
                UnitPrice = 18000000, UnitsInStock = 70, UnitsOnOrder = 5, ReorderLevel = 8, Discontinued = false }
        };

        public static List<Order> Orders = new() {
            new Order { OrderID = 1, CustomerID = 1, EmployeeID = 1, OrderDate = new DateTime(2024, 1, 15) },
            new Order { OrderID = 2, CustomerID = 2, EmployeeID = 2, OrderDate = new DateTime(2025, 2, 10) },
            new Order { OrderID = 3, CustomerID = 3, EmployeeID = 3, OrderDate = new DateTime(2025, 1, 15) },
            new Order { OrderID = 4, CustomerID = 4, EmployeeID = 4, OrderDate = new DateTime(2024, 2, 10) },
            new Order { OrderID = 5, CustomerID = 5, EmployeeID = 5, OrderDate = new DateTime(2025, 12, 15) },
            new Order { OrderID = 6, CustomerID = 6, EmployeeID = 6, OrderDate = new DateTime(2025, 11, 10) }
        };

        public static List<OrderDetail> OrderDetails = new() {
            new OrderDetail { OrderID = 1, ProductID = 1, UnitPrice = 2000000, Quantity = 2, Discount = 0 },
            new OrderDetail { OrderID = 1, ProductID = 2, UnitPrice = 15000000, Quantity = 1, Discount = 0.1f },
            new OrderDetail { OrderID = 3, ProductID = 3, UnitPrice = 2200000, Quantity = 10, Discount = 0 },
            new OrderDetail { OrderID = 4, ProductID = 4, UnitPrice = 2100000, Quantity = 9, Discount = 0 },
            new OrderDetail { OrderID = 5, ProductID = 5, UnitPrice = 16000000, Quantity = 6, Discount = 0.1f },
            new OrderDetail { OrderID = 6, ProductID = 6, UnitPrice = 17000000, Quantity = 7, Discount = 0 }
        };




    }
}
