using System;


namespace ConsoleMenu
{
    internal class SecretNumber
    { 
        public static void SecretNum()
        {
                Console.WriteLine("Please enter a number between 1 and 99");
                Random rand = new Random();
                int randomNumber = rand.Next(1, 99 + 1);
                while (true)
                {
                    string UserInput;
                    //error handling
                    while (true)
                    {
                        UserInput = Console.ReadLine();
                        try
                        {
                            if (1 > Convert.ToInt32(UserInput) || Convert.ToInt32(UserInput) > 99) { Convert.ToInt32("null"); };
                        }
                        catch
                        {
                            Console.WriteLine("Please enter a valid number");
                            continue;
                        }
                        break;
                    }

                    //end error handling
                    int UserNum = Convert.ToInt32(UserInput);
                    //check number
                    if (UserNum == randomNumber)
                    {
                        Console.WriteLine("You've guessed the right number");
                        // exit the while loop
                        break;
                    }
                    else if (UserNum < randomNumber)
                    {
                        Console.WriteLine("Guess higher");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Guess lower");
                        continue;
                    }
                
            }
        }
    }
}
