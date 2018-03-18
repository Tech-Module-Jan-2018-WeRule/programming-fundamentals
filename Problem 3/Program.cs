using System;

namespace C_Problem_1._Choose_a_Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            string profecion = Console.ReadLine();  // read from console some word

            switch (profecion)  //check what is profession 
            {  // in different cases write in console relevant drink  
                case "Athlete":
                    Console.WriteLine("Water");
                    break;
                case "Businessman":
                case "Businesswoman":
                    Console.WriteLine("Coffee");
                    break;
                case "SoftUni Student":
                    Console.WriteLine("Beer");
                    break;
               
                default:  
                    Console.WriteLine("Tea");
                    break;
            }


           
        }
    }
}
