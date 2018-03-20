//CONFIRMED by stanchevv
using System;
using System.Text;

namespace Chracter_Stats
{
    class CharacterStats
    {
        static void Main(string[] args)
        {
            //receive  name, current health, maximum health, current energy and maximum energy on separate lines
            String characterName = Console.ReadLine();
            int health = int.Parse(Console.ReadLine());
            int healthMax = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int energyMax = int.Parse(Console.ReadLine()); ;

            //displays information about a video game character
            Console.WriteLine("Name: " + characterName);
            Console.Write("Health: ");
            Console.Write(repeatStr("|", health + 1));
            Console.Write(repeatStr(".", healthMax - health));
            Console.WriteLine("|");
            Console.Write("Energy: ");
            Console.Write(repeatStr("|", energy + 1));
            Console.Write(repeatStr(".", energyMax - energy));
            Console.WriteLine("|");
        }
        public static String repeatStr(String text, int count)
        {
            StringBuilder statBar = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                statBar.Append(text);
            }
            return statBar.ToString();
        }
    }
}
