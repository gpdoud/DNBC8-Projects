using System;
using System.Collections.Generic;
using System.Text;

namespace ProductProject {
    
    public class BronseWidget : IProduct {

        private Product Product { get; set; }

        public double GetPrice() {
            return Product.GetPrice();
        }

        public string GetStateName() {
            return Product.GetStateName();
        }
        public string GetModelName() {
            return Product.GetModelName();
        }

        public BronseWidget() {
            Product = new Product {
                Code = "BW",
                Name = "Bronse Widget",
                Model = ModelType.Bronse
            };
        }
    }
}
