using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalLibrary {
    
    public class Boxer : Dog {

        public Boxer(string Name): base(Name) {

        }
        public Boxer() {

        }
        public override string GetTypeOfDog() {
            return "Boxer";
        }
    }
}
