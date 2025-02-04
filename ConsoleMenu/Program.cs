using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
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
                // Runs the Options method
                Program.Options();

                // Cannot find out why i cannot implement this to Options and make it work
                int givenNumber = Convert.ToInt32(Console.ReadLine());

                // Runs the Secret Number method
                if (givenNumber == 1)
                {
                    SecretNumber.SecretNum();
                }

                // Runs the Quiz method
                if (givenNumber == 2)
                {
                    Quiz.QuizGame();
                }

                // Runs the Name Game method
                if (givenNumber == 3)
                {
                    Names.nameGame();
                }

                // Runs the Calculator method
                if (givenNumber == 4)
                {
                    Calculator.Calculate();
                }

            }
        }

        // Give the options to the user
        // Would like to implement the readline in this method too
        public static void Options()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("\n 1. Secret number \n 2. Quiz \n 3. Names \n 4. Calculator");
        }
    }
}
