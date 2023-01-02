using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    public class Person
    {
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        public override string ToString()
        {
            return FirstName + " " + LastName + " " +
               Age;
        }

        /*public override string ToString()
        {
            return LastName;
               
        }*/

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        //override ToString to return the person's FirstName LastName Age
    }


}

