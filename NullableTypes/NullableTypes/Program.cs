using System;

namespace NullableTypes {
    class Program {
        static void Main(string[] args) {

            var math = new Major { Id = 1, Description = "Math", MinSat = 900 };

            var jane = new Student {
                Id = 1,
                Name = "Jane",
                GPA = 2.9,
                SAT = 1000,
                MajorId = math.Id,
                Major = math
            };
            var bill = new Student { 
                Id = 2, 
                Name = "Bill", 
                GPA = 2.2, 
                SAT = null,
                MajorId = null,
                Major = null
            };
            var carol = new Student { 
                Id = 3, 
                Name = "Carol", 
                GPA = 3.3, 
                SAT = null 
            };

        }
    }
}
