using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class UsingSwitchCase
    {
        public static void PerformSwitchUse()
        {
            int emphrs;
            int empWagePrHrs = 20;
            //Constant variables
            const int PART_TIME = 1;
            const int FULL_TIME = 2;         
            Random random = new Random();           //random class
            int randomNum = random.Next(0, 3);     //generating random number from 0 to 2
            switch (randomNum)                    //passing random number into switch case to get employee work hours
            {
                case FULL_TIME:                 //passing constant variable in case value
                    emphrs = 8;
                    break;
                case PART_TIME:
                    emphrs = 4;
                    break;
                default:
                    emphrs = 0;
                    break;
            }
            int totalWage = emphrs * empWagePrHrs;                //Total Wage
            Console.WriteLine("Employee total Wage: " + totalWage);
        }
    }
}
