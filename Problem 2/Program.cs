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
            Console.Write("Enter Short side of figure: ");
            var Short_size = int.Parse(Console.ReadLine());
            Console.Write("Enter Long side of figure: ");
            var Long_size = int.Parse(Console.ReadLine());

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
