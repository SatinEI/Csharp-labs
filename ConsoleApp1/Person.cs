using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class Person
    {
        private string? Name;
        private int Age;

        public string? name
        {
            get { return Name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty.");
                }
                Name = value;
            }
        }
        public int age
        {
            get { return Age; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Age must be between 0 and 100.");
                }
                Age = value;
            }
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Person: {Name}, {Age} years old");
        }
    }
}