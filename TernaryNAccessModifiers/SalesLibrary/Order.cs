using System;
using System.Collections.Generic;
using System.Text;

namespace TernaryNAccessModifiers {
    
     public class Order {

        private static int lastId = -1;

        public string ToConsole() {
            return $"Id[{Id}], Amount[{Amount}]";
        }

        static Order() {
            lastId = 0;
        }

        public Order() {
            this.Id = lastId += 7;
        }

        public int Id { get; private set; }
        public double Amount { get; set; }
        public Customer Customer { get; set; }

        public void SetCustomer(Customer customer) {
            this.Customer = customer;
        }
    }
}
