using System.Runtime.Intrinsics.X86;
using System;

// Review Classes, Constructors, and Properties

namespace scratchpad
{
    public class Person
    {
        public DateTime Birthdate { get; private set; }

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days/365;

                return years;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1985, 1, 1));
            System.Console.WriteLine(person.Age);
        }
    }
}
