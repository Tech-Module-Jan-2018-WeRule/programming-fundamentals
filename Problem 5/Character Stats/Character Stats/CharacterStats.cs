using System;
using System.Text;

namespace Chracter_Stats
{
    class CharacterStats
    {
        static void Main(string[] args)
        {

            String name = Console.ReadLine();
            int health = int.Parse(Console.ReadLine());
            int healthmax = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int energymax = int.Parse(Console.ReadLine()); ;

            Console.WriteLine("Name: " + name);
            Console.Write("Health: ");
            Console.Write(repaeatStr("|", health + 1));
            Console.Write(repaeatStr(".", healthmax - health));
            Console.WriteLine("|");
            Console.Write("Energy: ");
            Console.Write(repaeatStr("|", energy + 1));
            Console.Write(repaeatStr(".", energymax - energy));
            Console.WriteLine("|");
        }
        public static String repaeatStr(String text, int count)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                sb.Append(text);
            }
            return sb.ToString();
        }
    }
}
