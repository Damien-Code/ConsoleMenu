using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SecretNumber secretNumber = new SecretNumber();
            Names names = new Names();
            Quiz quiz = new Quiz();
            Calculator calculator = new Calculator();

            while (true)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("\n 1. Secret number \n 2. Quiz \n 3. Names \n 4. Calculator");
                int givenNumber = Convert.ToInt32(Console.ReadLine());

                if (givenNumber == 1)
                {
                    SecretNumber.SecretNum();
                }

                if (givenNumber == 2)
                {
                    Quiz.QuizGame();
                }

                if (givenNumber == 3)
                {
                    Names.nameGame();
                }

                if (givenNumber == 4)
                {
                    Calculator.Calculate();
                }
                
            }
        }
    }
}
