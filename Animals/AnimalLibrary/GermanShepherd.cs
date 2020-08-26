using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalLibrary {
    
    public class GermanShepherd : Dog {

        public bool BigDog { get; set; } = true;

        public GermanShepherd(string Name) : base(Name) {
            this.LongTail = true;
        }
        public GermanShepherd() {
            this.Muzzle = MuzzleType.Long;
            this.LongTail = true;

        }
        public override string GetTypeOfDog() {
            return "German Shepherd";
        }

    }
}
