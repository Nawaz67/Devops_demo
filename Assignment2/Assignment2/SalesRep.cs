using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment2
{
    public class SalesRep
    {
        public string SalesPerson { get; set; }
        public List<Sales> SalesList { get; set; }

        public SalesRep(string salePerson, List<Sales> salesList)
        {
            SalesPerson = salePerson;
            SalesList = salesList;

        }

        public List<Sales> SalesUpdate()
        {
            foreach (var item in SalesList)
            {
                if (item.SalesPerson == SalesPerson && item.CommissionPaid == 0)
                {
                    if (item.Amount <= 2000)
                    { item.CommissionPaid = 0.05 * item.Amount; }
                    else if (item.Amount > 2000 && item.Amount <= 10000)
                    { item.CommissionPaid = 0.04 * item.Amount; }
                    else { item.CommissionPaid = 0.03 * item.Amount; }

                }

            }
            return SalesList;
        }

        /*salesperson
        *
        * Assumptions:
        * Only the unpaid sales(CommissionPaid= 0) records will be used for payment
        *
        *
        * Calculation for the CommissionPaid:
        * Sales commission is calculated as described below
        * 5% of the invoice amount <= $2000 +
        * 4% of the invoice amount >$2000 and <=$10000 +
        * 3% of the invoice amount >$10000
        * For examples,
        * 1. If Amount is 1000 then CommissionPaid will be $50
        * 2. If Amount is 6000 then CommissionPaid will be 260
        * 3. If Amount is 12000 then CommissionPaid will be $480
        *
        * Pay
        * _salesList.CommissionPaid should be updated with the correct amount as described above
        * Method should return the total commission just paid.
        */


        // Implement here



    public double TotalCommisssion()
        {

            var res1 = (from table in SalesList
                        where table.SalesPerson == "Bill"
                        select table.CommissionPaid).Sum();

            return res1;
        }


    }
}


