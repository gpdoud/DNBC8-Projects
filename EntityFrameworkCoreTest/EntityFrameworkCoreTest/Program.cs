using System;
using System.Linq;
using EntityFrameworkCoreTest.Models;

namespace EntityFrameworkCoreTest {
    class Program {
        static void Main(string[] args) {
            var _context = new AppDbContext();

            var cust = new Customer { Id = 0, Name = "Target" };
            _context.Customers.Add(cust);
            var affected = _context.SaveChanges();

            _context.Customers.ToList().ForEach(c => Console.WriteLine(c));
        }
    }
}
