﻿using System;
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
            while (true)
            {
                // Initialize the Person method
                Person person = new Person();
                Person person2 = new Person("John doe", 22);
                Console.WriteLine("What is your name?");
                person.Name = Console.ReadLine();
                Console.WriteLine("What is your age?");
                person.Age = Convert.ToInt32(Console.ReadLine());

                // Runs the Talk method
                person.Talk();

                // Runs the constructor for person2
                person2.Talk();

                //Console.WriteLine("Please choose your favorite day!");
                //string weekday = Console.ReadLine();

                //Weekdays();

            }
        }

    }

    // Class for person
    internal class Person
    {
        private string _name;
        private int _age;
        private static int _count;

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
                return _age; // * 99;
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
            // use private properties so it does not conflict with possible getter manipulations
            Console.WriteLine($"Hello, my name is {_name} and im {_age} years old!");
            NumberOfPersons();
        }

        public Person()
        {
            Name = "";
            Age = 0;
        }


        // Constructor for person
        public Person(string name, int age)
        {
            Name = name;
            Age = age;

        }

        public static int InstanceCounter()
        {
            _count++;
            return _count;
        }

        // Method to display count of persons
        public static void NumberOfPersons()
        {
            Console.WriteLine("There are {0} persons", InstanceCounter());
        }

        

        
    

    }

}
