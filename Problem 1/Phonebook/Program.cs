namespace Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {

            // change name of token to token
            // We recieve from the console some info from the console about people and their phone numbers.

            var token = Console.ReadLine().Split().ToList();

            var phonebook = new Dictionary<string, string>();

            // If we recieve "END"– stop receiving more commands.

            while (token[0] != "END")
            {
                // Adds entry to the phonebook. In case of trying to add a name that is already in the phonebook we 
                // should change the existing phone number with the new one provided.
                if (token[0] == "A" && token.Count > 2)
                {
                    phonebook[token[1]] = token[2];
                }

                // Searches for a contact by given name and prints it in format "{name} -> {number}".
                // In case the contact isn't found, print "Contact {name} does not exist.".
                else
                {
                    if (phonebook.ContainsKey(token[1]))
                    {
                        Console.WriteLine("{0} -> {1}", token[1], phonebook[token[1]]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", token[1]);
                    }
                }
                token = Console.ReadLine().Split().ToList();
            }
        }
    }
}
