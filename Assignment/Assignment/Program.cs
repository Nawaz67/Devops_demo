using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {

            var people = new List<Person>()
        {
            new Person("Bill", "Smith", 41),
            new Person("Sarah", "Jones", 22),
            new Person("Stacy","Baker", 21),
            new Person("Vivianne","Dexter", 19 ),
            new Person("Bob","Smith", 49 ),
            new Person("Brett","Baker", 51 ),
            new Person("Mark","Parker", 19),
            new Person("Alice","Thompson", 18),
            new Person("Evelyn","Thompson", 58 ),
            new Person("Mort","Martin", 58),
            new Person("Eugene","deLauter", 84 ),
            new Person("Gail","Dawson", 19 ),

        };

            //1.write linq statement for people with last name that starts with the letter D
            var result = from person in people
                         where person.LastName.StartsWith('D')
                         select person;

            foreach (var item in result)
            {
                
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------");

            //2.write a linq statement for people with last names that starts with the letter D and displays the count.
            var result1 = (from person in people
                           where person.LastName.StartsWith('D')
                           select person).Count();
            
            Console.WriteLine(result1);
            Console.WriteLine("-----------------------------");

            //3.Write linq statement for first Person Older Than 40 In Descending Alphabetical Order By First Name
            var result2 = from person in people
                          where person.Age > 40
                          orderby person.Age descending, person.FirstName
                          select person;
            foreach (var item in result2)
            {
                
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------");

            //4.write linq statement for people’s full name(concat firstname and last name)
            var result3 = from person in people
                          select person.FirstName + "-" + person.LastName;
            foreach (var item in result3)
            {
                
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------------------Next Set--------------------------------");

            //Another queries
            //1. Write a query that returns most frequent character in string.Assume that there is only one such character.
            string str = "panda";
            var frequentCharacter = str.GroupBy(b => b).OrderByDescending(b => b.Count()).First().Key;
            Console.WriteLine(frequentCharacter);

            //2.Find out Unique values, Given a non - empty list of strings, return a list that contains only unique(non - duplicate) strings.
            var list1 = new[] { "abc", "xyz", "klm", "xyz", "abc", "abc", "rst" };
            var list2 = list1.Where(x => list1.Where(y => y == x).Count() == 1);
            foreach (var item in list2)
            {
               
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------");

            //3.Top 5 numbers, Write a query that returns top 5 numbers from the list of integers in descending order.
            List<int> lis = new List<int>() { 78, -9, 0, 23, 54, 21, 7, 86 };
            var result4 = (from l in lis
                           orderby l descending
                           select l).Take(5);
            foreach (var item in result4)
            {
                
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------");

            // 4.Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };
            var result5 = from li in fruits
                          where li.StartsWith('L')
                          select li;
            foreach (var item in result5)
            {
                
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------");

            // 5.Which of the following numbers are multiples of 4 or 6 
            List<int> mixedNumbers = new List<int>()
             {
                 15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
             };
            var result6 = from ns in mixedNumbers
                          where ns % 4 == 0 || 4 % 6 == 0                             
                          select ns;
             foreach (var item in result6)
             {
                Console.WriteLine(item);
             }
            Console.WriteLine("-----------------------------");
            //6.Output how many numbers are in this list
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
            var result7 = (from li in numbers
                           select li).Count();
            
            Console.WriteLine(result7); 
            Console.WriteLine("-----------------------------");

            // 7. How much money have we made?
            List<double> purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };
            var result8 = (from li in purchases
                           select li).Sum();
            
            Console.WriteLine(result8);
            Console.WriteLine("-----------------------------");

            // 8. What is our most expensive product?
            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };
            var result9 = (from li in purchases
                           select li).Max();
            
            Console.WriteLine(result9);
            Console.WriteLine("-----------------------------");

            //9.Given the same customer set, display how many millionaires per bank

            List<Customer> customers = new List<Customer>() {
                new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
                new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
                new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
                new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
                new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
                new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
                new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
                new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
                new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
                new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
            };
            var million = from mil in customers
                          where mil.Balance >= 1000000
                          group mil by mil.Bank into val
                          select new
                          {
                              Bank = val.Key,
                              Millon_per_bank = val.Count()
                          };
            foreach (var item in million)
            {
                Console.WriteLine(item.Bank+" "+item.Millon_per_bank);
            }

            Console.WriteLine("-------------------------");

            //10.Display Top 3 customers per bank.
            var cust = from cus in customers
                       group cus by cus.Bank into val
                       select new
                       {
                           Bank = val.Key,
                       };
            foreach (var item in cust)
            {
                var pop= (from p in customers
                         where p.Bank==item.Bank 
                         orderby p.Balance
                         select p).Take(3);
                Console.WriteLine(item.Bank);
                foreach (var item2 in pop)
                {
                    Console.WriteLine(item2);
                }
             
            }
        }

    }
}
