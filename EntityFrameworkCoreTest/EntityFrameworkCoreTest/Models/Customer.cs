using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkCoreTest.Models {
    
    public class Customer {

        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString() => $"{Id}/{Name}";
        public Customer() {

        }
    }
}
