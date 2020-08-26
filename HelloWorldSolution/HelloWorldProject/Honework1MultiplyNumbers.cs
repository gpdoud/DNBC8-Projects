using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldProject {
    class Honework1MultiplyNumbers {

        public void Start() {

            // multiply the numbers from 1 to 10 and display the result
            var product = 1;
            for(var number = 1; number <= 10; number++) {
                product = product * number;
            }
            Console.WriteLine($"Product of numbers 1 to 10 is {product}");
            
            // alternate solution
            product = 1;
            var nbr = 1;
            while(nbr <= 10) {
                product *= nbr;
                nbr++;
            }
            Console.WriteLine($"Product of numbers 1 to 10 is {product}");
        }
    }
}
