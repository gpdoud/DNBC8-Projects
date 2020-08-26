using System;

namespace AnimalLibrary {

    public enum MuzzleType { Long, Short, Collapsed };
    public enum BarkPitchEnum { High, Medium, Low };

    public class Dog {

        public bool LongTail { get; set; }
        public BarkPitchEnum BarkPitch { get; set; } // high, medium, low
        public MuzzleType Muzzle { get; set; } // long, short, collapsed
        public bool ExtremeSenseOfSmell { get; set; } = false;
        public string Name { get; set; }

        public virtual string GetTypeOfDog() {
            return "Dog";
        }

        public Dog(string Name) {
            if(Name == null) {
                this.Name = "Doggy";
            } else {
                this.Name = Name;
            }
        }
        public Dog() {

        }

    }
}
