using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekday
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var weekday = DateTime.Now.DayOfWeek;
            Console.WriteLine(weekday);

        }
        enum Message
        {
            Sunday = 0,
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            
        }

        public static void Weekdays()
        {

            Message message = Message.Monday;

            switch (message)
            {
                case Message.Monday:
                    Console.WriteLine("What a day!");
                    break;
                case Message.Tuesday:
                    Console.WriteLine("This is tuesday!");
                    break;
                case Message.Wednesday:
                    Console.WriteLine("This is wednesday");
                    break;
                case Message.Thursday:
                    Console.WriteLine("This is thursday!");
                    break;
                case Message.Friday:
                    Console.WriteLine("This is friday!");
                    break;
                case Message.Saturday:
                    Console.WriteLine("This is saturday!");
                    break;
                case Message.Sunday:
                    Console.WriteLine("This is sunday");
                    break;
                default:
                    Console.WriteLine("Please choose a correct day");
                    break;

            }
        }
        }
}
