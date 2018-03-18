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

            var token= Console.ReadLine().Split().ToList();

            var phonebook = new Dictionary<string, string>();

            while (token[0] != "END")
            {
                if (token[0] == "A" && token.Count > 2)
                {
                    phonebook[token[1]] = token[2];
                }
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
                token= Console.ReadLine().Split().ToList();
            }
        }
    }
}
