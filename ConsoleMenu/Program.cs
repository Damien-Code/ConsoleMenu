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

            while (true)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("\n 1. Secret number \n 2. Quiz \n 3. Names \n 4. Calculator");
                int givenNumber = Convert.ToInt32(Console.ReadLine());

                if (givenNumber == 1) { 
                    SecretNumber.SecretNum();
                }

                //if (givenNumber == 1)
                //{
                //    Console.WriteLine("Please enter a number between 1 and 99");
                //    Random rand = new Random();
                //    int randomNumber = rand.Next(1, 99 + 1);
                //    while (true)
                //    {
                //        string UserInput;
                //        //error handling
                //        while (true)
                //        {
                //            UserInput = Console.ReadLine();
                //            try
                //            {
                //                if (1 > Convert.ToInt32(UserInput) || Convert.ToInt32(UserInput) > 99) { Convert.ToInt32("null"); };
                //            }
                //            catch
                //            {
                //                Console.WriteLine("Please enter a valid number");
                //                continue;
                //            }
                //            break;
                //        }

                //        //end error handling
                //        int UserNum = Convert.ToInt32(UserInput);
                //        //check number
                //        if (UserNum == randomNumber)
                //        {
                //            Console.WriteLine("You've guessed the right number");
                //            // exit the while loop
                //            break;
                //        }
                //        else if (UserNum < randomNumber)
                //        {
                //            Console.WriteLine("Guess higher");
                //            continue;
                //        }
                //        else
                //        {
                //            Console.WriteLine("Guess lower");
                //            continue;
                //        }
                //    }
                //}

                if (givenNumber == 3)
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

                if (givenNumber == 2)
                {
                    List<string> questions = new List<string>()
            {
                "What is the capitol of the Netherlands?",
                "What is 3 * 3?",
                "What is 5 + 5?"
            };
                    List<string> answerA = new List<string>()
            {
                "Amsterdam",
                "5",
                "35"
            };
                    List<string> answerB = new List<string>()
            {
                "Madrid",
                "9",
                "16"
            };
                    List<string> answerC = new List<string>()
            {
                "Lisbon",
                "21",
                "10"
            };
                    List<string> correctAnswer = new List<string>()
            {
                "a",
                "b",
                "c"
            };

                    int score = 0;

                    for (int i = 0; i < questions.Count; i++)
                    {
                        string question = questions[i];
                        Console.WriteLine($"{i + 1}) {question}");
                        Console.WriteLine($"A. {answerA[i]}");
                        Console.WriteLine($"B. {answerB[i]}");
                        Console.WriteLine($"C. {answerC[i]}");

                        string answer = Console.ReadLine().ToLower();
                        if (answer == correctAnswer[i])
                        {
                            score++;
                        }
                    }

                    Console.WriteLine($"Your final score is {score} / {questions.Count}");
                }

                if (givenNumber == 4)
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
    }
}
