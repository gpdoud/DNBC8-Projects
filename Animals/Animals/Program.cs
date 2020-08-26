using System;
using System.Collections.Generic;
using AnimalLibrary;

namespace Animals {
    class Program {
        static void Main(string[] args) {

            var boxer1 = new Boxer();
            var pug1 = new Pug("ThePug");
            var pug2 = new Pug();
            var gs1 = new GermanShepherd("Killer");
            var germanSheperd = new GermanShepherd {
                LongTail = true,
                BarkPitch = BarkPitchEnum.Low,
                Muzzle = MuzzleType.Long,
                ExtremeSenseOfSmell = true,
                BigDog = false
                //,Name = "Fred"
            };
            var pug = new Dog {
                LongTail = false,
                BarkPitch = BarkPitchEnum.High,
                Muzzle = MuzzleType.Collapsed,
                ExtremeSenseOfSmell = false,
                Name = "Ralph"
            };

            var dogs = new List<Dog>();
            dogs.Add(pug);
            dogs.Add(germanSheperd);
            dogs.Add(gs1);
            dogs.Add(pug2);
            dogs.Add(pug1);
            dogs.Add(boxer1);

            foreach(var dog in dogs) {
                Console.WriteLine(dog.GetTypeOfDog());
            }
        }
    }
}
