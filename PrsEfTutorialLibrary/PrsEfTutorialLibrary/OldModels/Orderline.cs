using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace PrsEfTutorialLibrary.Models {
    
    public class Orderline {

        public int Id { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }

        [JsonIgnore]
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }

        public override string ToString() 
            => $"{Id}/{Order.Description}/{Product.Code}:{Product.Name}:{Product.Price}/{Quantity}/{Quantity * Product.Price}";
        public Orderline() { }
    }
}
