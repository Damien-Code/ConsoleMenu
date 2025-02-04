using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenu
{
    internal class Quiz
    {
        public static void QuizGame()
        {
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
        }
    }
}
