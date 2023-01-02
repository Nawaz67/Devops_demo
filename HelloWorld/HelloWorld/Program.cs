using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    
    /*//enum
    public enum ShippingMethod
    {
        RegularAirMail=1,
        RegisteredAirMail=2,
        Express=3
    }*/
    class Program
    {
        static void Main(string[] args)
        {
            //while loop
            /*for (int i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }*/

            var i = 0;
            while (i <= 10)
            {
                if (i % 2 == 0)
             
                    Console.WriteLine(i);
                i++;
                

            }



                //foreach loop
                /*var name = "Nawaz Sharieff";
                var numbers=new int[] {1,2,3,4};

                //for (int i = 0; i < name.Length; i++)
                //{
                //    Console.WriteLine(name[i]);
                //}

                foreach (var number in numbers)
                {
                    Console.WriteLine(number);
                }

                foreach (var character in name)
                {
                    Console.WriteLine(character);
                }*/


                //for loop
                /*for (int i = 0; i <= 10; i++)
                {
                    if(i%2==0)
                    {
                        Console.WriteLine(i);
                    }
                }

                for (int i = 10; i >= 1; i--)
                {

                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }*/


                //Switch case

                /*var season=Season.Autumn; 

                switch(season)
                {
                    case Season.Autumn:
                    case Season.Spring:
                        Console.WriteLine("It is summer season");
                        break ;
                    default:
                        Console.WriteLine("i dont understand that season");
                        break;
                }*/

                //conditional operator

                /*bool isGoldCustomer=true;
                float price;
                if (isGoldCustomer)
                    price = 19.95f;
                else
                    price = 29.95f;

                float price = (isGoldCustomer) ? 19.95f : 29.95f;
                Console.WriteLine(price);
    */


                //If else

                /*int hour = 10;
                if (hour > 0 && hour < 12)
                {


                    Console.WriteLine("It is morning");
                }
                else if (hour > 12 && hour < 18)
                {
                    Console.WriteLine("It is afternoon");
                }
                else
                {
                    Console.WriteLine("It is evening");
                }*/


                /* //Enums
                 var method = ShippingMethod.Express;
                 Console.WriteLine((int)method);

                 var methodId = 3;
                 Console.WriteLine((ShippingMethod)methodId);
                 //Console.Clear();
                 Console.WriteLine(method.ToString());

                 Console.WriteLine(method);
                 Console.Clear();
                 var methodName = "Express";
                 var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
                 Console.WriteLine(methodName);*/

                /*//Strings

                var firstName = "Mosh";
                var lastName = "Hame";
                var fullName = firstName + " " + lastName;

                var myFullName = string.Format("M name is {0} {1}", firstName, lastName);

                var names = new string[3] { "john", "ram", "marry" };
                var formattedNames=string.Join(" , ", names);
                Console.WriteLine(formattedNames);
                Console.WriteLine(names);
                Console.WriteLine(myFullName);

                //Verbatim string
                var text = @"Hi John
    Look into the   following paths
    c:\folder1\folder2";
                Console.WriteLine(text);*/

                //Arrays
                /*
                            var numbers = new int[4];
                            numbers[0] = 1;
                            numbers[1] = 2;
                            numbers[2] = 3;
                            numbers[3] = 4;
                            Console.WriteLine(numbers[0]);
                            Console.WriteLine(numbers[1]);  
                            Console.WriteLine(numbers[2]);  
                            Console.WriteLine(numbers[3]);

                            var flags = new bool[4];
                            flags[0] = true;
                            flags[1] = true;

                            Console.WriteLine(flags[0]);
                            Console.WriteLine(flags[1]);
                            Console.WriteLine(flags[2]);
                            Console.WriteLine(flags[3]);

                            var names = new string[3] { "ab", "bc", "cd" };
                            Console.WriteLine(names[0]);*/



                /* var john = new Person();
                   john.FirstName = "John";
                   john.LastName="Smith";
                   john.Introduce();

                   Calculator calculator = new Calculator();
                   var result=calculator.Add(5, 3);
                   Console.WriteLine(result);  */


                //Operators
                /*var a = 1;
                var b= 2;
                var c = 3;
                Console.WriteLine(!(c>b || c==a));
    */
                /*try
                {
                    string str = "true";
                    bool b=Convert.ToBoolean(str);
                    Console.WriteLine(b);

                }
                catch (Exception)
                {
                    Console.WriteLine("The number cannot be converted to byte");

                }*/

                //Type conversion
                /*var number = "12354";
                int i = Convert.ToInt32(number);
                Console.WriteLine(i);

                int i = 256;
                byte b = (byte) i;
                Console.WriteLine(b);*/

                /*const float Pi = 3.14f;
                Console.WriteLine(Pi);
    */
                //Min and Max Value
                /*Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
                Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);*/

                //Use of Variables
                /*var number = 2;
                var count = 10;
                var totalPrice = 20.95f;
                var character = 'A';
                var firstName = "mosh";
                var isWorking=false;
                Console.WriteLine(number);
                Console.WriteLine(count);
                Console.WriteLine(totalPrice);
                Console.WriteLine(character);
                Console.WriteLine(firstName);
                Console.WriteLine(isWorking);*/
            }
    }
}
