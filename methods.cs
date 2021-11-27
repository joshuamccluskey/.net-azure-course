//Name: Joshua McCluskey
//Date: 11.27.2021
//File Name: method.cs
//Purpose: This is to use methods and parameters in different ways  building a pyramid

using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            MyFirstMethod();
            Pyramid();
            PyramidChoice(1);
            PyramidChoice(2);
            PyramidChoice(3);
            PyramidChoice(4);
            PyramidChoice(5);
            PyramidChoice(6);
            PyramidChoice(7);
            PyramidChoice(8);
            PyramidChoice(9);
            PyramidChoice(10);

            //Instead of wrtiing out parameters used for loop for better design
            for (int i = 1; i < 11; i++)
            {
                PyramidChoice(i);
            }

            PyramidArray();

           

        }

        //Testing out a method
        public static void MyFirstMethod()
        {

            Console.WriteLine("What's up? You excuted your first method!\n");
        }

        //Method prints a 3 row pyramid
        public static void Pyramid()
        {
            Console.WriteLine("Here's a pyramid!");

            for (int i = 0; i <= 3; i++)
            {
                if (i < 1)
                {
                    Console.WriteLine("  *   ");

                }
                else if (i < 2)
                {
                    Console.WriteLine(" ***  ");
                }
                else if (i < 3)
                {
                    Console.WriteLine("*****\n");
                }
            }    
        }

        // Method allows user to add parameter to choose the height of their pyramid
        public static void PyramidChoice(int blocks)
        {
            Console.WriteLine("You chose the pyramid's height! = " + blocks);
            if (blocks == 1)
            {
                Console.WriteLine("  *   ");
            }
            else if (blocks == 2)
            {
                Console.WriteLine("  *   \n" + " ***  ");
            }
            else if (blocks == 3)
            {
                Console.WriteLine("  *   \n" + " ***  \n" + "*****");
            }
            else if (blocks == 4)
            {
                Console.WriteLine("   *    \n" + "  ***   \n" + " ***** \n" + "*******");
            }
            else if (blocks == 5)
            {
                Console.WriteLine("    *     \n" + "   ***    \n" + "  *****  \n" + " ******* \n" + "*********");
            }
            else if (blocks == 5)
            {
                Console.WriteLine("    *     \n" + "   ***    \n" + "  *****  \n" + " ******* \n" + "*********");
            }
            else if (blocks == 6)
            {
                Console.WriteLine("      *       \n" + "     ***      \n" + "    *****    \n" + "   *******   \n" + "  *********  \n" + " ***********");
            }
            else if (blocks == 7)
            {
                Console.WriteLine("       *        \n" + "      ***       \n" + "     *****     \n" + "    *******    \n" + "   *********   \n" + "  ***********  \n" + " ************* ");
            }
            else if (blocks == 8)
            {
                Console.WriteLine("        *         \n" + "       ***        \n" + "      *****      \n" + "     *******     \n"
                    + "    *********    \n" + "   ***********   \n" + "  *************  \n" + " ***************");
            }
            else if (blocks == 9)
            {
                Console.WriteLine("         *          \n" + "        ***         \n" + "       *****       \n" + "      *******      \n"
                    + "     *********     \n" + "    ***********    \n" + "   *************   \n" + "  ***************  \n" + " *****************");
            }

            else if (blocks == 10)
            {
                Console.WriteLine("          *           \n" + "         ***          \n" + "        *****        \n" + "       *******       \n"
                    + "      *********      \n" + "     ***********     \n" + "    *************    \n" + "   ***************   \n" + "  *****************  \n" + " *******************");
            }
        }

        //Method designed for using an a array to test and check if each pyramid level is correct

        public static void PyramidArray()
        {
            string[] levels = new string[10];
            levels[0] = "  *   ";
            levels[1] = "  *   \n" + " ***  ";
            levels[2] = "  *   \n" + " ***  \n" + "*****";
            levels[3] = "   *    \n" + "  ***   \n" + " ***** \n" + "*******";
            levels[4] = "    *     \n" + "   ***    \n" + "  *****  \n" + " ******* \n" + "*********";
            levels[5] = "      *       \n" + "     ***      \n" + "    *****    \n" + "   *******   \n" + "  *********  \n" + " ***********";
            levels[6] = "       *        \n" + "      ***       \n" + "     *****     \n" + "    *******    \n" + "   *********   \n" + "  ***********  \n" + " ************* ";
            levels[7] = "        *         \n" + "       ***        \n" + "      *****      \n" + "     *******     \n"
                    + "    *********    \n" + "   ***********   \n" + "  *************  \n" + " ***************";
            levels[8] = "         *          \n" + "        ***         \n" + "       *****       \n" + "      *******      \n"
                    + "     *********     \n" + "    ***********    \n" + "   *************   \n" + "  ***************  \n" + " *****************";
            levels[9] = "          *           \n" + "         ***          \n" + "        *****        \n" + "       *******       \n"
                    + "      *********      \n" + "     ***********     \n" + "    *************    \n" + "   ***************   \n" + "  *****************  \n" + " *******************";

            foreach (string amount in levels)
            {
                Console.WriteLine("Test successful!");
                Console.WriteLine(amount);
            }
        }
    }
}
