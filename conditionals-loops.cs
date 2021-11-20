//Name: Joshua McCluskey
//Date: 11.20.2021
//File Name: conditionals-loops.cs
//Purpose: Utilizing different forms of conditional statements and loops

using System;

namespace conditionals_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //if conditional statement
            int grade = 98;
            if (grade > 90)
            {
                Console.WriteLine("You got an A!");
            }

            //if else conditional statement
            int grade1 = 80;
            if (grade1 < 90)
            {
                Console.WriteLine("You got an B!");
            }
            else
            {
                Console.WriteLine("You got an A!");
            }

            // ternary operator contional short hand statement

            int grade2 = 80;
            var result = (grade2 > 90) ? "You got an A!" : "You got a B!";
            Console.WriteLine(result);

            //ternary operator extreme shorthand conditional statement
            int grade3 = 90;
            Console.WriteLine((grade3 < 90) ? "You got a B!" : "You got an A!");

            //if else if conditional statement

            int grade4 = 58;

            if (grade4 < 60)
            {
                Console.WriteLine("You got an F!");
            }
            else if (grade4 < 70)
            {
                Console.WriteLine("You got a D!");
            }
            else if (grade4 < 80)
            {
                Console.WriteLine("You got a C!");
            }
            else if (grade4 < 90)
            {
                Console.WriteLine("You got a B!");
            }
            else
            {
                Console.WriteLine("You got an A!");
            }

            ////while loop counter
            int counter = 0;
            while (counter < 10)
            {
                Console.Write(counter);
                counter++;
            }

            //do ...while loop counter
            int counter1 = 3;
            do
            {
                Console.Write(counter1);
                counter1 --;
            }
            while (counter1 > 0);

            //for loop counter

            for (int i = 0; i < 10; i +=2)
            {
                Console.WriteLine(i);
            }

            //Combine for loop with if...statement
            for (int i = 0; i < 100; i +=10)
            {
                if (i < 60)
                {
                    Console.WriteLine("You got an F!");
                }
                else if (i < 70)
                {
                    Console.WriteLine("You got a D!");
                }
                else if (i < 80)
                {
                    Console.WriteLine("You got a C!");
                }
                else if (i < 90)
                {
                    Console.WriteLine("You got a B!");
                }
                else
                {
                    Console.WriteLine("You got an A!");
                }
            }

        }
    }
}
