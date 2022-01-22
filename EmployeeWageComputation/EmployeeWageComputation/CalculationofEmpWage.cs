using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class CalculationofEmpWage
    {
        /// <summary>
        /// UC 8
        /// Computing wage for employees of multiple companies
        /// </summary>
        /// 
        //Constant Variables
        const int PART_TIME = 1;
        const int FULL_TIME = 2;
        //static variable
        public static int emphrs;

        // method to perform Employee Wage Computation program using different parameters
        public static void WageCompute(string company, int wagePerHrs, int totalWorkHrs, int totalWorkDay)
        {
            //Declaring Local Variables
            int totalWage = 0;
            int totalEmpWorkHr = 0;
            int totalEmpwrkDay = 1;
          
            Random randomNum = new Random();   //Creating Object of Random Class
                       
            while (totalEmpWorkHr <= totalWorkHrs && totalEmpwrkDay <= totalWorkDay)
            {
                int empCheck = randomNum.Next(0, 3);     //generating random number from 0 to 2
                GetEmpHrs(empCheck);                    //calling static method to get emp work hr
                int empWage = emphrs * wagePerHrs;
                Console.WriteLine("Emp wage for day{0} is: {1}", totalEmpwrkDay, empWage);
                totalWage += empWage;
                totalEmpWorkHr = emphrs + totalEmpWorkHr;      //Computing Total Work Hrs of Employee Day wise
                totalEmpwrkDay++;                           //incrementing Number of Day Worked.
            }
            Console.WriteLine("\nEmployee of company:{0} and Total wage is:{1} ", company, totalWage);
        }

           
            public static void GetEmpHrs(int empCheck)  //Static Method to Get Employee work hours
        {
                switch (empCheck)       //Using switch case to get employee work hours
                {
                    case FULL_TIME:
                        emphrs = 8;
                        break;
                    case PART_TIME:
                        emphrs = 4;
                        break;
                    default:
                        emphrs = 0;
                        break;
                }
            }
        }
    }
