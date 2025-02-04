using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenu
{
    internal class Calculator
    {
        public static void Calculate()
        {
            while (true)
            {
                Console.WriteLine("Welcome to the calculator");
                Console.WriteLine("1. Addition \n 2. Substraction \n 3. Multiply \n 4. Division \n");
                int action = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your first input");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your second input");
                int num2 = Convert.ToInt32(Console.ReadLine());

                switch (action)
                {
                    case 1:
                        Console.WriteLine($"Your output is:  {num1 + num2}");
                        break;
                    case 2:
                        Console.WriteLine($"Your output is:  {num1 - num2}");
                        break;
                    case 3:
                        Console.WriteLine($"Your output is:  {num1 * num2}");
                        break;
                    case 4:
                        Console.WriteLine($"Your output is:  {num1 / num2}");
                        break;
                    default:
                        Console.WriteLine("Please select a correct action");
                        break;
                };

            };
        }
    }
}
