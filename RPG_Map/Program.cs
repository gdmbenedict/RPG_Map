using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Map
{
    
    internal class Program
    {
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

        // usage: map[y, x]

        // map legend:
        // ^ = mountain
        // ` = grass
        // ~ = water
        // * = trees

        static void Main(string[] args)
        {
            DisplayMap(3);
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
            Console.WriteLine(printLine);

            //increments the rows of the array
            for (int i=0; i < map.GetLength(0); i++)
            {
                //scales columns to correct size
                for (int j=0; j<scale; j++)
                {
                    //starts border
                    printLine = "|";

                    //increments through the columns of array
                    for (int k=0; k < map.GetLength(1); k++)
                    {
                        //scales rows to correct size
                        for (int l=0; l<scale; l++)
                        {
                            printLine += map[i,k];
                        }
                    }
                    //finishes line
                    printLine += "|";

                    //prints line to console.
                    Console.WriteLine(printLine);
                }
            }

            //creates bottom border
            printLine = "+";
            for (int i = 0; i < map.GetLength(1) * scale; i++)
            {
                printLine += "-";
            }
            printLine += "+";
            Console.WriteLine(printLine);
        }
    }
}
