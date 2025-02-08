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
                double action = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your first input");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter your second input");
                double num2 = Convert.ToDouble(Console.ReadLine());
                double result = 0;

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
        public static double Addition(double num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }

        // Returns result of Substraction method
        public static double Substraction(double num1, double num2)
        {
            double result = num1 - num2;
            return result;
        }

        // Returns result of Multiply method
        public static double Multiply(double num1, double num2)
        {
            double result = num1 * num2;
            return num1 * num2;
        }

        // Returns result of Division method
        public static double Division(double num1, double num2)
        {
            double result = num1 / num2;
            return result;
        }
    }
}
