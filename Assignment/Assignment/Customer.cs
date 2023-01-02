using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    public class Customer
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public string Bank { get; set; }
        public override string ToString()
        {
            return Name + " " + Balance + " " +
               Bank;
        }
        public Customer()
        {

        }
    }
}
