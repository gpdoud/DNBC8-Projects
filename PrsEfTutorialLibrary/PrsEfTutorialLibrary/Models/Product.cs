using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace PrsEfTutorialLibrary.Models {
    
    public class Product {

        public int Id { get; set; }
        public string PartNbr { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Unit { get; set; }
        public string PhotoPath { get; set; }
        
        public int VendorId { get; set; }
        public virtual Vendor Vendor { get; set; }
        [JsonIgnore]
        public virtual IEnumerable<Requestline> Requestlines { get; set; }

        public Product() { }
    }
}
