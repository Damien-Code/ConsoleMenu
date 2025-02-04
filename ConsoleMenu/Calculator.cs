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
                Console.WriteLine(" 1. Addition \n 2. Substraction \n 3. Multiply \n 4. Division \n");
                int action = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your first input");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your second input");
                int num2 = Convert.ToInt32(Console.ReadLine());
                int result = 0;

                    switch (action)
                    {
                        case 1:
                            result = Addition(num1, num2);
                            break;
                        case 2:
                            result = Substraction(num1, num2);
                            break;
                        case 3:
                            result = Multiply(num1, num2);
                            break;
                        case 4:
                            result = Division(num1, num2);
                            break;
                        default:
                            Console.WriteLine("Please select a correct action");
                            break;
                    };
                Console.WriteLine("The result is {0} \n", result);
            };
        }

        // Returns result of Addition method
        public static int Addition(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        // Returns result of Substraction method
        public static int Substraction(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }

        // Returns result of Multiply method
        public static int Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            return num1 * num2;
        }

        // Returns result of Division method
        public static int Division(int num1, int num2)
        {
            int result = num1 / num2;
            return result;
        }
    }
}
