using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What would you would like to do? \n 1. Add X \n 2. Add * \n 3. Random");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add your text");
            if (input == 1)
            {
                string output = PrettyString.Addxs(Console.ReadLine());
                Console.WriteLine(output);
            }
            if (input == 2)
            {
                string output = PrettyString.Addstars(Console.ReadLine());
                Console.WriteLine(output);
            }
            if (input == 3)
            {
                string output = PrettyString.PrintRandom(Console.ReadLine());
                Console.WriteLine(output);
            }
        }
    }

    internal static class PrettyString
    {
        public static string Addxs(string s)
        {
            return $"X {s} X";
            //Console.WriteLine("X {0} X ", s);
        }

        public static string Addstars(string s)
        {
            return $"* {s} *";
        }

        public static string PrintRandom(string s)
        {
            
            int random = new Random().Next(0, 3);
            switch(random)
            {
                case 0:
                    return Addstars(s);   
                case 1:
                    return Addxs(s);
                case 2:
                    return $":) {s} (:";
                default:
                    return s;
            }
            //return random switch
            //{
            //    0 => Addstars(s),
            //    1 => Addxs(s),
            //    _ => Addstars(s),
            //};

        }

    }

}
