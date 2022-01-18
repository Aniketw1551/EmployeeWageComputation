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
            /// UC 7 
            /// Computing wage for Employee using class variables and methods
            /// </summary>
            /// 
            //Constant Variables
            const int FULL_TIME = 2;
            const int PART_TIME = 1;
            const int WAGE_PER_HRS = 20;
            const int TOTAL_WORK_HRS = 100;
            const int TOTAL_WORK_MONTH = 20;

            //Instanse variables
            int totalEmpWorkHr = 0;
            int totalEmpWorkDay = 1;
            public static int emphrs;
            int totalWage;

            // method to perform Employee Wage Computation program
            public void EmpWageCompute()
            {
                Random randomNum = new Random();          //Creating Object of Random Class
                                                                 
                while (totalEmpWorkHr <= TOTAL_WORK_HRS && totalEmpWorkDay <= TOTAL_WORK_MONTH)
                {
                    int empCheck = randomNum.Next(0, 3);     //generating random number from 0 to 2
                    GetEmpHrs(empCheck);                    //calling static method to get emp work hr
                    int empWage = emphrs * WAGE_PER_HRS;
                    Console.WriteLine("Emp wage for day{0} is: {1}", totalEmpWorkDay, empWage);
                    totalWage += empWage;
                    totalEmpWorkHr = emphrs + totalEmpWorkHr;      //Computing Total Work Hrs of Employee Day wise
                    totalEmpWorkDay++;                           //incrementing Number of Day Worked
                }
                Console.WriteLine("\nEmployee total Wage is: " + totalWage);
            }

           
            public static void GetEmpHrs(int empCheck)  //Static Method to Get Employee work hours
        {
                switch (empCheck)       //passing random number into switch to get employee work hours
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
