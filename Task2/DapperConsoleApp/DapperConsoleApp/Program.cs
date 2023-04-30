using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DapperConsoleApp.Models;
using DapperConsoleApp.Repository;
namespace DapperConsoleApp
{
    class Program
    {
        private static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DapperDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private static CategoryRepository _categoryRepository = new CategoryRepository(connectionString);
        private static OrderRepository _orderRepository = new OrderRepository(connectionString);
        private static ProductRepository _productRepository = new ProductRepository(connectionString);
        static async Task Main(string[] args)
        {

            // Create a new category
            Category category = new Category
            {
                CategoryName = "Test Category",
                Description = "This is a test category",
                Picture = "test.jpg"
            };
            int categoryId = await _categoryRepository.CreateCategory(category);
            Console.WriteLine("Created category with ID: " + categoryId);

            category = new Category
            {
                CategoryName = "Book",
                Description = "This is a test category",
                Picture = "test.jpg"
            };
            categoryId = await _categoryRepository.CreateCategory(category);
            Console.WriteLine("Created category with ID: " + categoryId);

            category = new Category
            {
                CategoryName = "Bike",
                Description = "This is a test category",
                Picture = "test.jpg"
            };
            categoryId = await _categoryRepository.CreateCategory(category);
            Console.WriteLine("Created category with ID: " + categoryId);

            category = new Category
            {
                CategoryName = "Shirt",
                Description = "This is a test category",
                Picture = "test.jpg"
            };
            categoryId = await _categoryRepository.CreateCategory(category);
            Console.WriteLine("Created category with ID: " + categoryId);

            category = new Category
            {
                CategoryName = "Shoes",
                Description = "This is a test category",
                Picture = "test.jpg"
            };
            categoryId = await _categoryRepository.CreateCategory(category);
            Console.WriteLine("Created category with ID: " + categoryId);

            // create a new product
            Product product = new Product
            {
                ProductName = "harry potter",
                CategoryID = 1,
                QuantityPerUnit = 10,
                UnitPrice = 50,
                UnitsInStock = 100,
                UnitsOnOrder = 0,
                ReorderLevel = 10,
                Discontinued = false,
                LastUserId = 1,
                LastDateUpdated = DateTime.Now
            };
            int productid = await _productRepository.CreateProduct(product);
            Console.WriteLine("created product with id: " + productid);

            product = new Product
            {
                ProductName = "the wisperer",
                CategoryID = 2,
                QuantityPerUnit = 12,
                UnitPrice = 50,
                UnitsInStock = 100,
                UnitsOnOrder = 0,
                ReorderLevel = 10,
                Discontinued = false,
                LastUserId = 1,
                LastDateUpdated = DateTime.Now
            };
             productid = await _productRepository.CreateProduct(product);
            Console.WriteLine("created product with id: " + productid);

            product = new Product
            {
                ProductName = "nike",
                CategoryID = 3,
                QuantityPerUnit = 5,
                UnitPrice = 50,
                UnitsInStock = 100,
                UnitsOnOrder = 0,
                ReorderLevel = 10,
                Discontinued = false,
                LastUserId = 1,
                LastDateUpdated = DateTime.Now
            };
             productid = await _productRepository.CreateProduct(product);
            Console.WriteLine("created product with id: " + productid);

            product = new Product
            {
                ProductName = "some product",
                CategoryID = 2,
                QuantityPerUnit = 77,
                UnitPrice = 50,
                UnitsInStock = 100,
                UnitsOnOrder = 0,
                ReorderLevel = 10,
                Discontinued = false,
                LastUserId = 1,
                LastDateUpdated = DateTime.Now
            };
            productid = await _productRepository.CreateProduct(product);
            Console.WriteLine("created product with id: " + productid);

            // create a new order
            Order order = new Order
            {
                CustomerID = 1,
                EmployeeID = 1,
                OrderDate = DateTime.Now,
                RequiredDate = DateTime.Now.AddDays(7),
                ShippedDate = DateTime.Now.AddDays(1),
                ShipVia = "plane",
                Freight = 10,
                ShipName = "john doe",
                ShipAddress = "123 main st.",
                ShipCity = "anytown",
                ShipRegion = "ca",
                ShipPostalCode = "12345",
                ShipCountry = "mkd"
            };
            int orderid = await _orderRepository.CreateOrder(order);
            Console.WriteLine("created order with id: " + orderid);

            order = new Order
            {
                CustomerID = 1,
                EmployeeID = 1,
                OrderDate = new DateTime(2008, 6, 1, 7, 47, 0),
                RequiredDate = DateTime.Now.AddDays(7),
                ShippedDate = DateTime.Now.AddDays(1),
                ShipVia = "car",
                Freight = 10,
                ShipName = "bon jovi",
                ShipAddress = "123 main st.",
                ShipCity = "anytown",
                ShipRegion = "ca",
                ShipPostalCode = "12345",
                ShipCountry = "mkd"
            };
            orderid = await _orderRepository.CreateOrder(order);
            Console.WriteLine("created order with id: " + orderid);

            order = new Order
            {
                CustomerID = 1,
                EmployeeID = 1,
                OrderDate = new DateTime(2008, 6, 1, 7, 47, 0),
                RequiredDate = DateTime.Now.AddDays(7),
                ShippedDate = DateTime.Now.AddDays(1),
                ShipVia = "car",
                Freight = 11,
                ShipName = "bon jovi",
                ShipAddress = "123 main st.",
                ShipCity = "anytown",
                ShipRegion = "ca",
                ShipPostalCode = "12345",
                ShipCountry = "mkd"
            };
            orderid = await _orderRepository.CreateOrder(order);
            Console.WriteLine("created order with id: " + orderid);

            order = new Order
            {
                CustomerID = 1,
                EmployeeID = 1,
                OrderDate = new DateTime(2013, 6, 1, 7, 47, 0),
                RequiredDate = DateTime.Now.AddDays(7),
                ShippedDate = DateTime.Now.AddDays(1),
                ShipVia = "truck",
                Freight = 20,
                ShipName = "bon jovi",
                ShipAddress = "123 main st.",
                ShipCity = "anytown",
                ShipRegion = "ca",
                ShipPostalCode = "12345",
                ShipCountry = "srb"
            };
            orderid = await _orderRepository.CreateOrder(order);
            Console.WriteLine("created order with id: " + orderid);

            order = new Order
            {
                CustomerID = 1,
                EmployeeID = 1,
                OrderDate = new DateTime(2002, 6, 1, 7, 47, 0),
                RequiredDate = DateTime.Now.AddDays(7),
                ShippedDate = DateTime.Now.AddDays(1),
                ShipVia = "car",
                Freight = 30,
                ShipName = "marko",
                ShipAddress = "123 main st.",
                ShipCity = "anytown",
                ShipRegion = "ca",
                ShipPostalCode = "12345",
                ShipCountry = "GR"
            };
            orderid = await _orderRepository.CreateOrder(order);
            Console.WriteLine("created order with id: " + orderid);

            OrderDetails orderDetails = new OrderDetails
            {
                OrderID = 1,
                ProductID = 1,
                UnitPrice = 20,
                Quantity = 45,
                Discount = 0
            };
            await _orderRepository.CreateOrderDetails(orderDetails);
            orderDetails = new OrderDetails
            {
                OrderID = 2,
                ProductID = 2,
                UnitPrice = 23,
                Quantity = 72,
                Discount = 5
            };
            await _orderRepository.CreateOrderDetails(orderDetails);
            orderDetails = new OrderDetails
            {
                OrderID = 3,
                ProductID = 2,
                UnitPrice = 240,
                Quantity = 76,
                Discount = 7
            };
            await _orderRepository.CreateOrderDetails(orderDetails);
            // get a list of orders sorted by date
            List<Order> orders = (List<Order>) await _orderRepository.GetOrdersSortedByDate();
            Console.WriteLine("orders sorted by date:");
            foreach (Order o in orders)
            {
                Console.WriteLine(o.OrderID + " - " + o.OrderDate);
            }

            // get a list of all products sorted by most sold products
            List<Product> products = (List<Product>) await _productRepository.GetMostSoldProducts();
            Console.WriteLine("products sorted by most sold:");
            foreach (Product p in products)
            {
                Console.WriteLine(p.ProductID + " - " + p.ProductName + " - " + p.QuantityPerUnit);
            }

            // get a list of all categories sorted by most sold products
            List<Category> categories = (List<Category>)await _categoryRepository.GetCategoriesSortedByMostSoldProducts();
            Console.WriteLine("categories sorted by most sold:");
            foreach (Category c in categories)
            {
                Console.WriteLine(c.CategoryId + " - " + c.CategoryName + " - " + c.TotalQuantitySold);
            }

            Console.ReadKey();
        }
    }
}
