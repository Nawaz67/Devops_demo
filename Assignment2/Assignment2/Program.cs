using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sales = new List<Sales>()
            {
                new Sales(){ InvoiceId = "INV102", SalesPerson="Bill", Amount=1200,CommissionPaid=60 },
                new Sales(){ InvoiceId = "INV107", SalesPerson="Dave", Amount=4200,CommissionPaid=0 },
                new Sales(){ InvoiceId = "INV106", SalesPerson="Paul", Amount=16000,CommissionPaid=0},
                new Sales(){ InvoiceId = "INV103", SalesPerson="Mark", Amount=18000,CommissionPaid=0 },
                new Sales(){ InvoiceId = "INV101", SalesPerson="Sayeed", Amount=2000,CommissionPaid=0 },
                new Sales(){ InvoiceId = "INV109", SalesPerson="Christine", Amount=5200,CommissionPaid=0 },
                new Sales(){ InvoiceId = "INV108", SalesPerson="Bill", Amount=6000,CommissionPaid=0 },
                new Sales(){ InvoiceId = "INV104", SalesPerson="Mary", Amount=9800,CommissionPaid=0 },
                new Sales(){ InvoiceId = "INV105", SalesPerson="Bill", Amount=12000,CommissionPaid=0 },
                new Sales(){ InvoiceId = "INV100", SalesPerson="Melissa", Amount=12000,CommissionPaid=0 }
            };
            //Display all Bill's Sales Records(Both paid and unpaid).

            // Implement here
            var result = from table in sales
                         where table.SalesPerson == "Bill"
                         select table;
            foreach (var item in result)
            {
                Console.WriteLine(item.SalesPerson + "\t");
                Console.WriteLine(item.InvoiceId + "\t");
                Console.WriteLine(item.Amount + "\t");
                Console.WriteLine(item.CommissionPaid);

            }

            /* Call a method from SalesRep class to pay the sales commission for Bill(only for the sales records with CommissionPaid=0)
            * Display the total commission that has been paid
            */

            // Implement here
            SalesRep salesrep = new SalesRep("Bill", sales);

            List<Sales> result1 = salesrep.SalesUpdate();
            var res = from table in result1
                      where table.SalesPerson == "Bill"
                      select table;

            var res1 = (from table in result1
                        where table.SalesPerson == "Bill"
                        select table.CommissionPaid).Sum();
            double totalcommission = salesrep.TotalCommisssion();

            foreach (var item in res)
            {
                Console.Write(item.SalesPerson + "\t");
                Console.Write(item.InvoiceId + "\t");
                Console.Write(item.Amount + "\t");
                Console.Write(item.CommissionPaid + "\n");
                Console.WriteLine();
            }
            Console.WriteLine(totalcommission + " is total commission");


        }

    }


}
   