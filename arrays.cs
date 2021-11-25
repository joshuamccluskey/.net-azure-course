//Name: Joshua McCluskey
//Date: 11.24.2021
//File Name: Program.cs
//Purpose: Learning and excuting vasrious forms of arrays

using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assinging values by index number

            double[] transaction = new double[8];
            transaction[0] = 100.67;
            transaction[1] = 30.99;
            transaction[2] = 64.88;
            transaction[3] = 88.88;
            transaction[4] = 0.99;
            transaction[5] = 1234.56;
            transaction[6] = 300.87;
            transaction[7] = 400.39;

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("Credit Transaction " + i + "=" + transaction[i]);
            }

            //Assigning values by time of declaration

            int[] accountNumbers = { 1567, 2345, 3678};

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Accounts Number " + i + "=" + accountNumbers[i]);
            }

            //Create and intialize array

            string[] classRoster = new string[6] {"Pam", "Joe", "Bob", "Sue", "Lou", "Ray"};

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Student " + i + "=" + classRoster[i]);
            }

            //Omit size of the array from previous example

            string[] classRoster1 = new string[] {"Pam", "Joe", "Bob", "Sue", "Lou", "Ray"};

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Student " + i + "=" + classRoster1[i]);
            }

            //Copy an array and assign new variable

            string[] classRoster2 = new string[] {"Pam", "Joe", "Bob", "Sue", "Lou", "Ray"};

            string[] attendance = classRoster2;

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(attendance[i] + " is present in class" );
            }

            //For Each loop example

            foreach (double amount in transaction)
            {
                Console.WriteLine("Credit Transaction: " + amount);
            }

            Console.ReadKey();
        }
    }
}
