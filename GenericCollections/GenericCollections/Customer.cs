using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollections {
    class Customer {

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; } = true;

        public Customer(int Id, string Name, bool Active) {
            this.Id = Id;
            this.Name = Name;
            this.Active = Active;
        }
        public Customer() { }

    }
}
