using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace PrsEfTutorialLibrary.Models {
    
    public class Vendor {

        public int Id { get; set; } = 0;
        public string Code { get; set; } = $"C{DateTime.Now.Millisecond}";
        public string Name { get; set; } = "Vendor";
        public string Address { get; set; } = "123 St";
        public string City { get; set; } = "Mason";
        public string State { get; set; } = "OH";
        public string Zip { get; set; } = "45040";
        public string Phone { get; set; }
        public string Email { get; set; }

        [JsonIgnore]
        public virtual IEnumerable<Product> Products { get; set; }

        public Vendor() { }

        public override string ToString() => $"{Id}/{Code}:{Name}";
    }
}
