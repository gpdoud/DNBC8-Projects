using System;
using System.Collections.Generic;
using System.Text;

namespace ProductProject {
    
    public class SilverWidget : IProduct{

        private Product Product { get; set; }

        public double GetPrice() {
            return Product.GetPrice();
        }

        public string GetModelName() {
            return Product.GetModelName();
        }
        public string GetStateName() {
            return Product.GetStateName();
        }


        public SilverWidget() {
            Product = new Product {
                Code = "SW",
                Name = "Silver Widget",
                Model = ModelType.Silver
            };
        }
    }
}
