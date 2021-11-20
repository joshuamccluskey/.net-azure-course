//Name: Joshua McCluskey
//Date: 11.17.2021
//File Name: hello-world.cs
//Purpose: This method is a HelloWorld app to print diffrent data types and variables to the consoles.

using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // HelloWorld app to print diffrent data types to the consoles. This is my Hello World application and introduction to C# and Visual Studio
            /*I'm introducing myself to the world using C#.
             * Let me know if there is anything that I can improve
             */
            string FirstName = "Joshua";
            string LastName = "McCluskey";
            int Age = 30;
            double Os = 12.01;
            char MiddleInitial = 'C';
            string City = "Seattle, WA";
            bool Alive = true;
            Console.WriteLine("Hello World! Hello I'm " + FirstName + " "+ MiddleInitial+ " " +LastName + "!");
            Console.WriteLine("I'm " + Age);
            Console.WriteLine("I live in " + City);
            Console.WriteLine("I'm using macOS Monterey version " + Os);
            Console.WriteLine("Am I alive? " + Alive);
            Console.ReadKey();
        }
    }
}
