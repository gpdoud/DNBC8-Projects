using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldProject {
    class Lesson1 {

        public void Start() {
            /*
             * Declaring a variable
             * You declare a variable by using the keyword 'var' followed by the
             * variable name. Variables declared with var must be initialized and
             * can only be done within methods
             */
            var counter = 0; // declare a variable and initialize it
            counter = counter + 1; // increment; add 1
            Console.WriteLine("Counter value is " + counter); // string concatenation (+)
            counter += 1; // increment; add 1 - better
            Console.WriteLine("Counter value is {0}", counter); // placeholder substitution - better
            counter++; // increment; add 1 - best!
            Console.WriteLine($"Counter value is {counter}"); // interpolation - best
            if(counter == 3) {
                Console.WriteLine("Counter value is three");
            } else {
                Console.WriteLine("Counter value is not three");
            }
            var sum = 0;
            for(var index = 0; index <= 25; index++) {
                sum += index;
            }
            Console.WriteLine($"Sum is {sum}");
        }

    }
}
