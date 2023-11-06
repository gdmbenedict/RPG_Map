using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Map
{
    
    internal class Program
    {
        // usage: map[y, x]

        // map legend:
        // ^ = mountain
        // ` = grass
        // ~ = water
        // * = trees

        static char[,] map = new char[,] // dimensions defined by following data:
    {
        {'^','^','^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'^','^','`','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`'},
        {'^','^','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`','`','`'},
        {'^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','`','`','`','`','`','`'},
        {'`','`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`','`','`'},
        {'`','`','`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`'},
        {'`','`','`','`','`','`','`','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
    };

        static int scale;
        

        static void Main(string[] args)
        {
            bool check = false;

            //prompt user to input
            Console.WriteLine("Welcome to the map print program.");
            Console.Write("Please enter the integer scale of the map:");

            while (!check)
            {

                //get int from user
                string scalar = Console.ReadLine();

                check = int.TryParse(scalar, out scale);

                if (!check)
                {
                    Console.WriteLine("\nThat is not an integer.\nPlease enter the integer scale of the map:");
                }
            }

            Console.WriteLine();

            //prints map legend
            Console.WriteLine("Legend:");

            //mountains
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("^");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Mountain");

            //grass
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("`");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Grass");

            //water
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("~");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Water");

            //trees
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("*");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Trees");

            Console.WriteLine();

            DisplayMap(scale);

            Console.ReadLine();
        }

        //displays an RPG map by displaying each tile as a single character, with a UI border.
        static void DisplayMap()
        {
            DisplayMap(1);
        }

        //same as DisplayMap(); but display each tile scaled, as a grid of characters, with a (unscaled) UI border.
        static void DisplayMap(int scale)
        {
            string printLine;

            //creates top border
            printLine = "+";
            for (int i=0; i < map.GetLength(1)*scale; i++)
            {
                printLine += "-";
            }
            printLine += "+";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(printLine);

            //increments the rows of the array
            for (int i=0; i < map.GetLength(0); i++)
            {
                //scales columns to correct size
                for (int j=0; j<scale; j++)
                {
                    //starts border
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("|");
                    

                    //increments through the columns of array
                    for (int k=0; k < map.GetLength(1); k++)
                    {
                        //scales rows to correct size
                        for (int l=0; l<scale; l++)
                        {
                            //detects character and what color to draw
                            switch (map[i,k])
                            {
                                case '^':
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    break;

                                case '`':
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    break;

                                case '~':
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    break;

                                case '*':
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    break;

                                default:
                                    Console.ForegroundColor = ConsoleColor.White;
                                    break;
                            }

                            Console.Write(map[i,k]);
                        }
                    }

                    //finishes line
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("|");

                }
            }

            //creates bottom border
            printLine = "+";
            for (int i = 0; i < map.GetLength(1) * scale; i++)
            {
                printLine += "-";
            }
            printLine += "+";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(printLine);
        }
    }
}
