using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class CalculationofEmpWage
    {
        //Instance Variables
        const int FullTime = 2;
        const int PartTime = 1;
        int empHrs;
        int wagePerHrs = 20;
        int totalWage;
  
        /// <summary>
        /// Uc 6 
         //In this branch, We Computing Wage For a Employee for a given condition
         //condition is employee total work hrs becomes 100 or 20 days for a Month     
        /// </summary>
        public void WageCompute()
        {
            //Local Variables
            int totalWorkHrs = 100;
            int totalWorkDay = 20;
            int totalEmpWorkhr = 0;
            int totalEmpworkDay = 1;
            Random randomNum = new Random();          //Creating Object of Random Class
            //Checking condition        
            while (totalEmpWorkhr <= totalWorkHrs && totalEmpworkDay <= totalWorkDay)
            {
                int empCheck = randomNum.Next(0, 3);     //generating random number from 0 to 2.
                switch (empCheck)                    //passing random number into switch to get employee work hours
                {
                    case FullTime:
                        empHrs = 8;
                        break;
                    case PartTime:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                int empWage = empHrs * wagePerHrs;
                Console.WriteLine("Emp wage for day{0} is: {1}", totalEmpworkDay, empWage);
                totalWage += empWage;
                totalEmpWorkhr = empHrs + totalEmpWorkhr;      //Computing Total Work Hrs of Employee Day wise
                totalEmpworkDay++;                           //incrementing Number of Day Worked
            }
            Console.WriteLine("\nEmployee total Wage: " + totalWage);
        }
    }
}