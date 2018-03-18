using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace figureOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            //in the next 4 lines we are getting the input for our program - the two sides of the figure of stars that we are going to print
            Console.Write("Enter Short side of figure: ");
            var Short_size = int.Parse(Console.ReadLine());
            Console.Write("Enter Long side of figure: ");
            var Long_size = int.Parse(Console.ReadLine());

            //this for cycle prints the figure according to the input
            for (int rows = 0; rows != Short_size; rows++)
             {
                for (int cols= 0; cols != Long_size; cols++)
                {
                    if (rows == 0 || rows == Short_size - 1 || cols == 0 || cols == Long_size - 1) Console.Write("* ");
                    else Console.Write("  ");
                }
                Console.WriteLine(" ");
            }
            


        

        }
    }
}
