//Name: Joshua McCluskey
//Date: 12.01.2021
//File Name: Program.cs
//Purpose: To use try and catch to understand how it works


//using System;
//using System.IO;

//namespace try_catch
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                using(StreamReader sr = new StreamReader("/Users/joshuamccluskey/Desktop/cazure/try-catch/jamaica.txt"))
//                {
//                    string ln;

//                    while((ln = sr.ReadLine()) != null)
//                    {
//                        Console.WriteLine(ln);
//                    }
//                }
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine("The file could not be read");
//                Console.WriteLine("e.Message");
//            }
//            Console.ReadKey();
//        }
//    }
//}




// -----------------------------------------------------------------------------

using System;
using System.IO;

namespace try_catch
{
    class Program
    {
        static void Main(string[] args)
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

            using (StreamWriter sw = new StreamWriter("/Users/joshuamccluskey/Desktop/cazure/pyramid/pyramid.csv"))
            {
                foreach(string height in levels)
                {
                    sw.WriteLine(height);
                }
            }

            string ln = "";
            using (StreamReader sr = new StreamReader("/Users/joshuamccluskey/Desktop/cazure/pyramid/pyramid.csv"))
            {
                while ((ln = sr.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                }
            }
        }
    }
}
