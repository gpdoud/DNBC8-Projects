using System;

namespace StringsTutorialProject {
    class Program {
        static void Main(string[] args) {

            var st1 = new StringsTutorial();
            var fullname = st1.Fullname();
            Console.WriteLine($"Fullname is {fullname}");
            Console.WriteLine($"Fullname2 is {st1.Fullname2()}");

            var denise = new StringsTutorial("Denise", "Bartick");
            Console.WriteLine($"Denise {denise.Fullname()}");
            Console.WriteLine($"Denise {denise.Fullname2()}");

        }
    }
}
