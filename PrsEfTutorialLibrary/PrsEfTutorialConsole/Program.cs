using System;
using System.Linq;
using PrsEfTutorialLibrary;
using PrsEfTutorialLibrary.Controllers;
using PrsEfTutorialLibrary.Models;

namespace PrsEfTutorialConsole {
    class Program {
        static void Main(string[] args) {
            TestRequestController();
            //TestUserController();
            //TestVendorController();
        }
        static void TestRequestController() {
            var reqCtrl = new RequestController();
            var reqs = reqCtrl.GetRequestsToReviewNotOwn(2);
        }

        static void TestRequestlineController() {
            var reqlineCtrl = new RequestlineController();
        }

        static void TestVendorController() {
            var vndCtrl = new VendorController();
            var vendor = new Vendor();
            vendor.Name = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            vndCtrl.Insert(vendor);
        }

        static void TestUserController() { 

            var userCtrl = new UserController();
            userCtrl.GetAll().ToList().ForEach(u => Console.WriteLine(u));
            Console.WriteLine(userCtrl.GetByPk(1));
            var user = new User();
            user = userCtrl.Insert(user);
            Console.WriteLine(user);
            user.Firstname = "Noah";
            user.Lastname = "Phense";
            userCtrl.Update(user.Id, user);
            Console.WriteLine("Update successful!");
            userCtrl.GetAll().ToList().ForEach(u => Console.WriteLine(u));
            userCtrl.Delete(user);
            Console.WriteLine("Delete successful!");
        }
        /*
        #region Test2
        static void Test2() { 
        var context = new AppDbContext();
            RecalcOrderAmounts(context);
            //AddOrderline(context);
            //GetOrderlines(context);

            //Console.WriteLine($"Avg price is {context.Products.Average(x => x.Price)}");

            //var top2 = context.Products.Where(x => x.Id > 7).ToList();

            //var actCust = context.Customers.Where(x => x.Active).ToList();
            //AddProducts(context);
            //AddOrders(context);
            //UpdateCustomerSales(context);
            //AddCustomer(context);
            //GetCustomerByPk(context);
            //UpdateCustomer(context);
            //DeleteCustomer(context);
            //GetAllCustomers(context);
        }
        static void RecalcOrderAmount(int orderId, AppDbContext context) {
            var order = context.Orders.Find(orderId);
            var total = order.Orderlines.Sum(ol => ol.Quantity * ol.Product.Price);
            order.Amount = total;
            var rc = context.SaveChanges();
            if(rc != 1) throw new Exception("Order update of amount failed!");
        }
        static void RecalcOrderAmounts(AppDbContext context) {
            var orderIds = context.Orders.Select(x => x.Id).ToArray();
            foreach(var orderId in orderIds) {
                RecalcOrderAmount(orderId, context);
            }
        }
        static void GetOrderlines(AppDbContext context) {
            var orderlines = context.Orderlines.ToList();
            orderlines.ForEach(line =>
                Console.WriteLine(line));
        }
        static void AddOrderline(AppDbContext context) {

            var order1 = context.Orders.SingleOrDefault(o => o.Description == "Order 1").Id;
            var order2 = context.Orders.SingleOrDefault(o => o.Description == "Order 2").Id;
            var order3 = context.Orders.SingleOrDefault(o => o.Description == "Order 3").Id;
            var order4 = context.Orders.SingleOrDefault(o => o.Description == "Order 4").Id;
            var order5 = context.Orders.SingleOrDefault(o => o.Description == "Order 5").Id;

            var echo = context.Products.SingleOrDefault(p => p.Code == "ECHO").Id;
            var echodot = context.Products.SingleOrDefault(p => p.Code == "ECHODOT").Id;
            var echoshow = context.Products.SingleOrDefault(p => p.Code == "ECHOSHOW").Id;
            var firestick = context.Products.SingleOrDefault(p => p.Code == "FIRESTIK").Id;
            var firetv = context.Products.SingleOrDefault(p => p.Code == "FIRETV").Id;

            context.Orderlines.Add(new Orderline { Id = 0, OrderId = order1, ProductId = echo, Quantity = 2 });
            context.Orderlines.Add(new Orderline { Id = 0, OrderId = order1, ProductId = echodot, Quantity = 3 });

            context.Orderlines.Add(new Orderline { Id = 0, OrderId = order2, ProductId = echoshow, Quantity = 1 });
            context.Orderlines.Add(new Orderline { Id = 0, OrderId = order2, ProductId = firestick, Quantity = 2 });

            context.Orderlines.Add(new Orderline { Id = 0, OrderId = order3, ProductId = firetv, Quantity = 4 });
            context.Orderlines.Add(new Orderline { Id = 0, OrderId = order3, ProductId = echo, Quantity = 5 });

            context.Orderlines.Add(new Orderline { Id = 0, OrderId = order4, ProductId = echodot, Quantity = 1 });
            context.Orderlines.Add(new Orderline { Id = 0, OrderId = order4, ProductId = echoshow, Quantity = 4 });

            context.Orderlines.Add(new Orderline { Id = 0, OrderId = order5, ProductId = firestick, Quantity = 2 });
            context.Orderlines.Add(new Orderline { Id = 0, OrderId = order5, ProductId = firetv, Quantity = 1 });

            var rowsAffected = context.SaveChanges();
            if(rowsAffected != 10) throw new Exception("OrderLine Insert failed");
        }
        static void AddProducts(AppDbContext context) {
            var p1 = new Product { Id = 0, Code = "ECHO", Name = "Echo", Price = 99.99 };
            var p2 = new Product { Id = 0, Code = "ECHODOT", Name = "Echo", Price = 39.99 };
            var p3 = new Product { Id = 0, Code = "ECHOSHOW", Name = "Echo Show", Price = 119.99 };
            var p4 = new Product { Id = 0, Code = "FIRESTIK", Name = "Fire TV Stick", Price = 49.99 };
            var p5 = new Product { Id = 0, Code = "FIRETV", Name = "Fire TV Cube", Price = 129.99 };
            context.Products.AddRange(p1, p2, p3, p4, p5);
            context.SaveChanges();
        }
        static void UpdateCustomerSales(AppDbContext context) {
            var CustOrderJoin = from c in context.Customers
                                join o in context.Orders
                                on c.Id equals o.CustomerId
                                where c.Id == 3
                                select new {
                                    Amount = o.Amount,
                                    Customer = c.Name,
                                    Order = o.Description
                                };
            var orderTotal = CustOrderJoin.Sum(c => c.Amount);
            var cust = context.Customers.Find(3);
            cust.Sales = orderTotal;
            context.SaveChanges();
        }
        static void AddOrders(AppDbContext context) {
            var order1 = new Order { Id = 0, Description = "Order 1", Amount = 200, CustomerId = 3 };
            var order2 = new Order { Id = 0, Description = "Order 2", Amount = 400, CustomerId = 3 };
            var order3 = new Order { Id = 0, Description = "Order 3", Amount = 600, CustomerId = 3 };
            var order4 = new Order { Id = 0, Description = "Order 4", Amount = 800, CustomerId = 3 };
            var order5 = new Order { Id = 0, Description = "Order 5", Amount = 1000, CustomerId = 3 };

            context.AddRange(order1, order2, order3, order4, order5);
            var rowsAffected = context.SaveChanges();
            if(rowsAffected != 5) throw new Exception("Five orders did not add");
            Console.WriteLine("Added 5 orders");
        }
        static void DeleteCustomer(AppDbContext context) {
            var keyToDelete = 1;
            var cust = context.Customers.Find(keyToDelete);
            if(cust == null) throw new Exception("Customer not found");
            context.Customers.Remove(cust);
            var rowsAffected = context.SaveChanges();
            if(rowsAffected != 1) throw new Exception("Delete failed!");
        }
        static void UpdateCustomer(AppDbContext context) {
            var custPk = 3;
            var cust = context.Customers.Find(custPk);
            if(cust == null) throw new Exception("Customer not found");
            cust.Name = "Amazon Inc.";
            var rowsAffected = context.SaveChanges();
            if(rowsAffected != 1) throw new Exception("Failed to update customer");
            Console.WriteLine("Update Successful!");
        }
        static void GetCustomerByPk(AppDbContext context) {
            var custPk = 3;
            var cust = context.Customers.Find(custPk);
            if(cust == null) throw new Exception("Customer not found");
            Console.WriteLine(cust);
        }
        static void GetAllCustomers(AppDbContext context) {
            var custs = context.Customers.ToList();
            foreach(var c in custs) {
                Console.WriteLine(c);
            }
        }
        static void AddCustomer(AppDbContext context) {
            var cust = new Customer {
                Id = 0,
                Name = "Target",
                Sales = 0,
                Active = true
            };
            context.Customers.Add(cust);
            var rowsAffected = context.SaveChanges();
            if(rowsAffected == 0) throw new Exception("Add failed!");
            return;
        }
        #endregion
        #region Testing
        static void Test() {

            var _context = new AppDbContext();

            //var order = new Order {
            //    Id = 0, Description = "2nd MAX Order", Amount = 1000, CustomerId = 1
            //};
            //_context.Orders.Add(order);
            //var recsAffected = _context.SaveChanges();
            //Console.WriteLine($"Recs added is {recsAffected}");

            //var order1 = _context.Orders.Find(1);
            //if(order1 == null) throw new Exception("Order not found");
            //Console.WriteLine(order1);
            //order1.Amount *= 2;
            //_context.SaveChanges();

            var ordersTotal = (from c in _context.Customers
                               join o in _context.Orders
                               on c.Id equals o.CustomerId
                               select o.Amount).Sum();
            var cust = _context.Customers.Find(1);
            cust.Sales = ordersTotal;
            _context.SaveChanges();

            var customers = _context.Customers.ToList();
            customers.ForEach(c => Console.WriteLine(c));
            var orders = _context.Orders.ToList();
            orders.ForEach(o => Console.WriteLine(o));

        }
        #endregion
        */
    }
}
