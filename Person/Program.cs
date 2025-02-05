using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize the Person method
            Person person = new Person();

            Console.WriteLine("What is your name?");
            person.Name = Console.ReadLine();
            Console.WriteLine("What is your age?");
            person.Age = Convert.ToInt32(Console.ReadLine());

            // Runs the Talk method
            person.Talk();
        }

    }

    // Class for person
    internal class Person
    {
        private string _name;
        private int _age;

        // get set for Name
        public string Name { 
            // return value
            get 
            {
                return _name; 
            }
            // set value
            set
            {
                _name = value;
            }
        }

        // get set for age
        public int Age
        {
            // return value
            get
            {
                return _age;
            }
            // set value
            set
            {
                // set value to 0 if input is under 0
                if (value < 0)
                {
                    Console.WriteLine("You cant be under 0");
                    return;
                }
                _age = value;
            }

        }

        // Method that uses input of name and age
        public void Talk()
        {
            Console.WriteLine($"Hello, my name is {Name} and im {Age} old!");
        }
            
        

    }
}
