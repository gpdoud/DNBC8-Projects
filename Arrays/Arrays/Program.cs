using System;

namespace Arrays {
    class Program {
        static void Main(string[] args) {

            var numbers 
                = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            #region
            var total = 0;
            foreach(var nbr in numbers) {
                total += nbr * 3;
            }
            //Console.WriteLine($"Total is {total}");
            #endregion

            // Add up all the numbers multiplied by 3 but exclude all
            // numbers evenly divisible by 2


            #region Add up all the numbers multiplied by 3 but exclude all numbers evenly divisible by 3 or 5
            var total2 = 0;
            foreach(var nbr in numbers) {
                if(nbr % 3 == 0 || nbr % 5 == 0) {
                    continue; // skip it
                }
                total2 += nbr * 3;
            }
            Console.WriteLine($"Total is {total2}");
            #endregion

            // answer is 180


        }
    }
}
