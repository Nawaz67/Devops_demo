using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var role="admin";
            Report reportObj = new Report();
            reportObj.MyReport();
            MyDelegateReport myDelegateReport = new MyDelegateReport(reportObj.PdfReport);
            myDelegateReport += new MyDelegateReport(reportObj.ExcelReport);
            myDelegateReport += new MyDelegateReport(reportObj.XmlReport);
            if (role == " ")
                myDelegateReport("");
            else
            {
                myDelegateReport -= new MyDelegateReport(reportObj.XmlReport);
                myDelegateReport("");
            }
            

            myDelegateReport("");   //calling maultiple function same time





/*            Nokia nokiaObj = new Nokia();
            nokiaObj.Year = 2002;
            nokiaObj.Model = "123";
            nokiaObj.NokiaConfig();
            Nokia nokiaObj1 = new Nokia();
            nokiaObj1.Year = 2003;
            nokiaObj1.Model = "256";

            Samsung samsung = new Samsung();
            samsung.Year = 2016;
            samsung.Model = "963";*/

            //Employee employeeObj = new Employee();
            /* employeeObj.GetEmployeeName();*/

            //employeeObj.SearchEmployee(1);
            //employeeObj.SearchEmployee("Nawaz");
            //employeeObj.SearchEmployee(300.30);
            //employeeObj.SearchEmployee<int>(12);
            //employeeObj.SearchEmployee<string>("Nawaz");
            //employeeObj.SearchEmployee<bool>(true);
            //employeeObj.SearchEmployee<double>(50000);
            //employeeObj.SearchEmployee<object>(12345);

            //employeeObj.GetEmployeeDetails();
            //Console.WriteLine(employeeObj);





            /*Employee employeeObj = new Employee();
            employeeObj.Firstname = "Nawaz";
            
            employeeObj.CreateEmployee();
            employeeObj.UpdateEmployee();
            employeeObj.GetEmployeeDetails();
            employeeObj.SearchEmployee(22);
            employeeObj
            Console.ReadLine();*/
            /* Console.Write("Enter the value of a: ");
             int a = Convert.ToInt32(Console.ReadLine()); //conversion from string to Integer
             Console.Write("Enter the value of b: ");
             int b = Convert.ToInt32(Console.ReadLine());
             int c = a + b;
             Console.WriteLine("Value of a+b = " +c);
             Console.WriteLine("Successfully Completed");
             Console.Read(); //it will wait to press any key from the keyboard
            for(int i=0;i<4;i++)
            {

            }
            */
        }
    }
}
