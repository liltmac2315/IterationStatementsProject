﻿using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            // Write this loop 15 times
            // for ( int i = 0; i <5; i++)
            // {
            //      Console.WriteLine ($"{i}");
            // }


                for (int i = 0; i < 15; i++)
                {
                    Console.WriteLine($"{i}");
                }

                // Exercise 2
                //TODO - Read each comment and complete its instruction
                // like the example below

                //Create a List called "numbers" - DONE!
                var numbers = new List<int>();

                //-----START HERE------------------------------------------
                //Create a variable of type int and name it num
                //initialize the variable with a value of 0
                var myNumber = 0;



                // Create a do-while loop and use the template below:

                {
                    // Increment your varieble by 1

                    // Then add your variable to "numbers"


                } // <---- While your variable is less than 100

                do
                {
                    myNumber++; // 100

                    numbers.Add(myNumber); // 100

                } while (myNumber < 100);



                // Create a while loop
                // <--- While num is less than 200
                while (myNumber < 200)
                {
                    // Increment num by 1
                    myNumber++;
                    // Then add num to the collection numbers
                    numbers.Add(myNumber);
                    //HINT: copy how this was done in the do while loop

                }


                // This is to show the user that the numbers will start increasing on the console
                Console.WriteLine("Increase:");


                // Create a foreach loop using the collection - numbers
                //In the scope of the foreach loop, print each number in numbers
                foreach (var item in numbers)
                {
                    Console.WriteLine(item);
                }
                

                


                Console.WriteLine("");
                Console.WriteLine("Decrease:");


                // Create a for loop - this will print the numbers in reverse order - from 200 to 1
                // in your initializer set the value of i to 199
                // in your conditional, as long as i is less than or equal to the amount of items in "numbers" - use (numbers.Count)
                // AND as long as i is greater than or equal to 0
                // Decrement i by 1

                //start for loop here
                for (int i = 199; i >= 0; i--)
                {
                    // place numbers[i] inside of the Console.WriteLine() method
                    Console.WriteLine($"{numbers[i]}");
                }

                //------------End of exercise

                // Exercise 3

            }
        }
    }
