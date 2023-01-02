using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace csharp_training
{
    public class Employee
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public double Mobile { get; set; }

        /*public void GetEmployeeName()
        {
            try
            {
                Console.Write("Enter Accno: ");
                int accno = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException e)
            {
                Console.WriteLine("Invalid Input!!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error!!");
            }

        }
        

       public void CreateEmployee()
        {
            int[] empIds=new int[3]; //Array declatration
            string[] names=new string[3];

            int[] numbers = { 3, 4, 54, 6 }; //Array initialization

            for (int i = 0; i < names.Length; i++)
            {
                Console.Write("Enter Id: ");
                empIds[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Name: ");
                names[i] = Console.ReadLine();  
            }

            Console.WriteLine("Details: ");
            for (int i = 0; i < names.Length; i++)
            {
                
                Console.Write("IDS: ");
                Console.Write(empIds[i]+" ");
                Console.Write("Names: ");
                Console.WriteLine(names[i]+" ");
                
                
            }
            Console.ReadLine();

           *//* Console.WriteLine("Enter Id: ");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter firstname: ");
            Firstname = Console.ReadLine();
            Console.WriteLine("Enter Lastname: ");
            Lastname = Console.ReadLine();
            Console.WriteLine("Email: ");
            Email = Console.ReadLine();
            Console.WriteLine("Enter Mobile no: ");
            Mobile = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("************");
            Console.WriteLine("Created...");
            Console.WriteLine("Employee Details: "+Id+","+Firstname+","+Lastname+","+Email+","+Mobile+"");*//*
        }
        public void UpdateEmployee()
        {
            Id = 11;
            Firstname = "Raj";
            Lastname = "G";
            Email = "raj@gamil.com";
            Mobile = 3652410985;
            Console.WriteLine("************");
            Console.WriteLine("Updated...");
        }*/

        public void GetEmployeeDetails()
        {
            Dictionary<int, string> empData = new Dictionary<int, string>();
            empData.Add(101, "Nawaz");
            empData.Add(102, "Raj");
            empData.Add(103, "Ram");
            empData.Add(104, "Smith");
            var value = empData[102];
            //var,dynamic
            //var a=10;
            //var b = "10";
            //dynamic d1 = 10;
            //dynamic d2 = "10";

            foreach (var item in empData)
            {
                Console.WriteLine(item);
                Console.WriteLine(value);
            }


            /*List<int> values = new List<int>();
            values.Add(67);
            List<string> namevalues = new List<string>();
            namevalues.Add("Nawaz");
            List<double> salaryValues = new List<double>();
            salaryValues.Add(2000.369);

            List<Employee> employees = new List<Employee>();
            Employee employeeObj = new Employee(); 
            employeeObj.Id = 123;
            employeeObj.Email = "nawaz@gmail.com";
            employeeObj.Firstname = "Nawaz";
            employeeObj.Lastname = "S";
            employeeObj.Mobile = 253365;
            employees.Add(employeeObj);

            employeeObj = new Employee();
            employeeObj.Id = 256;
            employeeObj.Email = "sharieff@gmail.com";
            employeeObj.Firstname = "sharieff";
            employeeObj.Lastname = "S";
            employeeObj.Mobile = 256395;
            employees.Add(employeeObj);
            foreach (var item in employees)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Email);
                Console.WriteLine(item.Firstname);
                Console.WriteLine(item.Lastname);
                Console.WriteLine(item.Mobile);
            }*/






            //    object a = 10;
            //    int value = a;
            //    object b = "20";
            //    object c = true;
            //    object d = 4000;

            //ArrayList employeeList = new ArrayList();
            //employeeList.Add(123);
            //employeeList.Add("nawaz");
            //employeeList.Add(true);
            //employeeList.Add(600.12);
            //for (int i = 0; i < employeeList.Count; i++)
            //{
            //    Console.WriteLine(employeeList[i]);
            //}

            //Stack stackObj = new Stack();
            //stackObj.Push(11);
            //stackObj.Push("nawaz");
            //stackObj.Push(true);
            //stackObj.Push(600.13);

            //for (int i = 0; i < stackObj.Count; i++)
            //{
            //    Console.WriteLine(stackObj.Pop());
            //}

            //stackObj.Pop();
            //stackObj.Pop();
            //stackObj.Pop();
            //stackObj.Pop();

            //Console.WriteLine("************");
            //Console.WriteLine("Reading...");
            //Console.WriteLine("Employee Details: " + Id + "," + Firstname + "," + Lastname + "," + Email + "," + Mobile + "");
        }
       /*public void SearchEmployee(int Id)
        {
            if (Id==1)
            {
                Console.WriteLine("Reading...");
                Console.WriteLine("Employee Details: " + Id + ", " + Firstname + ", " + Lastname + ", " + Email + ", " + Mobile + "");
            }
        }
        public void SearchEmployee(string name)
        {
            if (name == "Raj")
            {
                Console.WriteLine("Reading...");
                Console.WriteLine("Employee Details: " + Id + ", " + Firstname + ", " + Lastname + ", " + Email + ", " + Mobile + "");
            }
        }
        
        public void SearchEmployee(double salary)
        {
            Console.WriteLine("Salary: " +salary);
        }*/
        public void SearchEmployee<T>(T input)
        {
            Console.WriteLine("My Input: " + input);
        }
    }
}
