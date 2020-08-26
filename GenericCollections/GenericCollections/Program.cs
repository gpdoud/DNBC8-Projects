using System;
using System.Collections.Generic;

namespace GenericCollections {
    class Program {
        static void Main(string[] args) {
            #region Generic array of ints
            // a generic array of ints
            var ints = new List<int>();
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);
            Console.WriteLine($"Number of ints is {ints.Count}");
            foreach(var anInt in ints) {
                Console.Write($" {anInt} ");
            }
            ints.Remove(2);
            Console.WriteLine($"Number of ints is {ints.Count}");
            foreach(var anInt in ints) {
                Console.Write($" {anInt} ");
            }
            #endregion
            #region Generic array of names
            // a generic array of names
            var studentNames = new List<string>(12);
            studentNames.Add("Armon");
            studentNames.Add("Danae");
            studentNames.Add("David");
            studentNames.Add("George");
            studentNames.Add("Ian");
            studentNames.Add("Laura");
            studentNames.Add("Manish");
            studentNames.Add("Parker");
            studentNames.Add("Robert");
            studentNames.Add("Sarah");
            studentNames.Add("Traci");
            studentNames.Add("Vaughn");
            
            foreach(var name in studentNames) {
                Console.Write($" {name} ");
            }
            #endregion
            #region Generic array of strings
            // generic array of strings
            var customers = new List<Customer>();
            var amazon = new Customer(1, "Amazon", true);
            var pg = new Customer(2, "P&G", true);
            var meijer = new Customer { Id = 3, Name = "Meijer", Active = true };
            var target = new Customer { Id = 4, Name = "Target" };
            var microsoft = new Customer(5, "Microsoft", false);

            customers.Add(amazon);
            customers.Add(pg);
            var custArray = new Customer[] { meijer, target, microsoft };
            customers.AddRange(custArray);

            Console.WriteLine();
            foreach(var customer in customers) {

                //if(customer.Active == true) {
                //    Console.Write($"{customer.Id}, {customer.Name}, {customer.Active}");
                //}

                if(customer.Active == false) {
                    continue;
                }
                Console.Write($"[{customer.Id}, {customer.Name}, {customer.Active}], ");

            }

            #endregion
            #region Name of customer whose id is 3
            Console.WriteLine();
            var custName = "Not Found";
            foreach(var cust in customers) {
                if(cust.Id == 33) {
                    custName = cust.Name;
                    break;
                }
            }
            Console.WriteLine($"Cust with Id of 3 is {custName}");
            #endregion

            var custDictionary = new Dictionary<int, Customer>();
            custDictionary.Add(amazon.Id, amazon);
            custDictionary.Add(target.Id, target);
            custDictionary.Add(meijer.Id, meijer);
            custDictionary.Add(pg.Id, pg);
            custDictionary.Add(microsoft.Id, microsoft);

            var cust2 = custDictionary[3];
            Console.WriteLine($"Customer id 3 is {cust2.Name}");

            cust2 = custDictionary[2];
            Console.WriteLine($"Customer id 2 is {cust2.Name}");

            Console.WriteLine($"Customer id 2 is {custDictionary[2].Name}");



            foreach(var key in custDictionary.Keys) {
                var customer = custDictionary[key];
                Console.WriteLine($"{customer.Name}");
            }
        }
    }
}
