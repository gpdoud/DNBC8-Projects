using System;

namespace TernaryNAccessModifiers {
    class Program {
        static void Main(string[] args) { 

            
            Console.WriteLine($"The cube of 17 is {Program.Cubed(17)}");
            var message = Customer.PrintNextId();
            Console.WriteLine(message);

            var cust1 = new Customer("Max Technical Training");
            Console.WriteLine(cust1);
            
            var cust2 = new Customer("Amazon");
            var cust3 = new Customer("Target");

            cust1.NationalAccount("yes");

            var order1 = new Order { Amount = 1000, Customer = cust1 };
            var order2 = new Order { Amount = 2000, Customer = cust2 };
        }
        static int Cubed(int nbr) {
            return nbr * nbr * nbr;
        }
    }
}
