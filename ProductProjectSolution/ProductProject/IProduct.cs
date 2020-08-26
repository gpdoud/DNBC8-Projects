using System;
using System.Collections.Generic;
using System.Text;

namespace ProductProject {

    public interface IProduct {

        public double GetPrice();
        public string GetModelName();
        public string GetStateName();

    }
}
