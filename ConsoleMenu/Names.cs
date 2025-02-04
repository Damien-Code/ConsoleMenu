using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenu
{
    internal class Names
    {
        public static void nameGame()
        {
            List<string> names = new List<string>
                {
                    "Anna",
                    "Bob",
                    "Charlie",
                    "Dave",
                    "Eva",
                    "Frank",
                    "Grace",
                    "Harry",
                    "Ivy",
                    "Jack"
                };

            Console.WriteLine("What is your name?");
            string title = Console.ReadLine();
            names.Add(title);
            foreach (string name in names)
            {
                if (name.Length < 5)
                {
                    Console.WriteLine(name);
                }
            }
            //foreach (string name in names) { 
            //    names = names.Skip(2).ToList();
            //    Console.WriteLine(name);
            //}

        }
    }
}
