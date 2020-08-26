using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PrsEfTutorialLibrary.Models {
    
    public class Product {

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public virtual List<Orderline> Orderlines { get; set; }

        public Product() { }
    }
}
