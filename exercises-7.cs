//Name: Joshua McCluskey
//Date: 12.04.2021
//File Name: Program.cs
//Purpose: C Sharp excersises writing pseudocode and work flows and solutions creating various useful methods

using System;
using System.IO;

namespace lecture_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //My Methods:

            CreateNewFile();
            DeleteFile();
            FileExist();
            Writer();
            Reader();
            




            // Excercise 1

            // Flowchart:
            // StreamWriter --> File Path --> Create balnk file -->  A file created with name mytest.txt successful creation
            // Pseudocode:
            // class Program
            //{
            //    static void Main(string[] args)
            //    {
            //        StreamWriter new filepath filename mytest.txt
            //    }

            // solution:
            static void CreateNewFile()
            { 
            using (StreamWriter sw = new StreamWriter("/Users/joshuamccluskey/Desktop/cazure/excercises-7/mytest.txt"))
            {

            }

            Console.WriteLine("Excercise 1:A file created with name mytest.txt ");
            }
            //------------------------------------------------------------------------------------------------------

            //Excercise 2

            // Flowchart:
            // Remove file --> Print The file mytest.txt deleted successfully.
            // --> or print File does not exist--> Exception
            // Pseudocode:
            // class Program
            //{
            //    static void Main(string[] args)
            //    {
            //      
            //        StreamWriter new filepath filename mytest.txt
            //    }
            //    try
            //    {
            //     Removing the file
            //       The file mytest.txt deleted successfully.
            //       Console log File does not exist 
            //    }
            //    Catch
            //    { Exception message}
            //     

            //  solution:
            static void DeleteFile()
            {


                try
                {
                    if (File.Exists("/Users/joshuamccluskey/Desktop/cazure/excercises-7/mytest.txt"))
                    {
                        File.Delete("/Users/joshuamccluskey/Desktop/cazure/excercises-7/mytest.txt");
                        Console.WriteLine("Excercise 2:The file mytest.txt deleted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Excercise 2:File does not exist");
                    }
                }
                catch (Exception MyExp)
                {
                    Console.WriteLine(MyExp.ToString());
                }
            }


            //------------------------------------------------------------------------------------------------------

            //Excercise 3

            // Flowchart:
            // Checks file exists --> A file created with name mytest.txt exists
            // --> or File does not exist.
            // Pseudocode:
            // class Program
            //{
            //    static void Main(string[] args)
            //    {
            //      
            //       conditional checking if file exists
            //   

            //  solution:


            static void FileExist() { 
            if (File.Exists("/Users/joshuamccluskey/Desktop/cazure/excercises-7/mytest.txt"))
            {
                Console.WriteLine("Excercise 3:A file created with name mytest.txt exists");
            }
            else
            {
                    Console.WriteLine("Excercise 3:File does not exist.");
            }
            }


            //------------------------------------------------------------------------------------------------------

            //Excercise 4

            // Flowchart:
            // Creates file --> Add content to file --- A file created with content name mytest.txt
            // Pseudocode:
            // class Program
            //{
            //    static void Main(string[] args)
            //    {
            //      
            //       using StreamWiter new file path
            //        {Writing content here}
            //
            //   

            //  solution:


            static void Writer()
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

                using (StreamWriter sw = new StreamWriter("/Users/joshuamccluskey/Desktop/cazure/excercises-7/mytest.txt"))
                {
                    foreach (string pyramids in levels)
                    {
                        sw.WriteLine(pyramids);
                    }
                }

                Console.WriteLine("Excercise 4:A file created with pyramids is mytest.txt");
            }


            //Excercise 5

            // Flowchart:
            // Creates file --> Add content to file --- A file created with content name mytest.txt --> Reads File in Console
            // Pseudocode:
            // class Program
            //{
            //    static void Main(string[] args)
            //    {
            //      
            //       using StreamReader new file path
            //
            //   

            //  solution:
            static void Reader()
            {

                string ln = "";

                Console.WriteLine("Excercise 5:Here is the content of the file mytest.txt :");
                using (StreamReader sr = new StreamReader("/Users/joshuamccluskey/Desktop/cazure/excercises-7/mytest.txt"))
                {
                    while ((ln = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(ln);
                    }
                }

                ////------------------------------------------------------------------------------------------------------

                //Excercise 6

                // Flowchart:
                // Creates file --> for each loop array-->Add content to file --- A file created with content name mytest.txt
                // Pseudocode:
                // class Program
                //{
                //    static void Main(string[] args)
                //    {
                //      
                //       using StreamWiter new file path
                //        {Writing content here}
                //
                //   

                //  solution:


                //static void Dyno()
                //{
                //    string[] levels1 = new string[10];
                //    levels1[0] = "  *   ";
                //    levels1[1] = "  *   \n" + " ***  ";
                //    levels1[2] = "  *   \n" + " ***  \n" + "*****";
                //    levels1[3] = "   *    \n" + "  ***   \n" + " ***** \n" + "*******";
                //    levels1[4] = "    *     \n" + "   ***    \n" + "  *****  \n" + " ******* \n" + "*********";
                //    levels1[5] = "      *       \n" + "     ***      \n" + "    *****    \n" + "   *******   \n" + "  *********  \n" + " ***********";
                //    levels1[6] = "       *        \n" + "      ***       \n" + "     *****     \n" + "    *******    \n" + "   *********   \n" + "  ***********  \n" + " ************* ";
                //    levels1[7] = "        *         \n" + "       ***        \n" + "      *****      \n" + "     *******     \n"
                //            + "    *********    \n" + "   ***********   \n" + "  *************  \n" + " ***************";
                //    levels1[8] = "         *          \n" + "        ***         \n" + "       *****       \n" + "      *******      \n"
                //            + "     *********     \n" + "    ***********    \n" + "   *************   \n" + "  ***************  \n" + " *****************";
                //    levels1[9] = "          *           \n" + "         ***          \n" + "        *****        \n" + "       *******       \n"
                //            + "      *********      \n" + "     ***********     \n" + "    *************    \n" + "   ***************   \n" + "  *****************  \n" + " *******************";

                //    using (StreamWriter sw = new StreamWriter("/Users/joshuamccluskey/Desktop/cazure/excercises-7/mytest.txt"))
                //    {
                //        foreach (string pyramids1 in levels1)
                //        {
                //            sw.WriteLine(pyramids1);
                //        }
                //    }

                //    Console.WriteLine("A file created with pyramids is mytest.txt");
                //}
            }
        }
    }
}
