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
        /// UC 6
        /// </summary>
        public static void EmpWageCompute() // Calling Static method 
        {
            const int FullTime = 2;
            const int PartTime = 1;
            const int totalWorkHrs = 100;
            const int empWagePerHrs = 20;
            const int totalWorkDays = 20;
            int totalempWorkHrs = 0;
            int totalempWorkDay = 0;
            int empWageHrs = 0;
            int totalWage = 0;
            int empWage = 0;

            Random random = new Random();           //Creating Object of Random Class

            int i = 0;
            while (totalempWorkHrs <= totalWorkHrs && totalempWorkDay <= totalWorkDays)
            {
                totalempWorkDay++;                       //incrementing Number of Day Worked
                int EmpAttendence = random.Next(0, 3); //Generating random number between 0 and 2

                switch (EmpAttendence) // Using switch case statement 
                {
                    case FullTime:
                        empWageHrs = 8;
                        Console.WriteLine("FullTime Employee is present");
                        break;
                    case PartTime:
                        empWageHrs = 4;
                        Console.WriteLine("PartTime employee is present");
                        break;
                    default:
                        empWageHrs = 0;
                        Console.WriteLine("Employee is absent");
                        break;
                }

                totalempWorkHrs = empWageHrs + totalempWorkHrs;
                i++;                                            // incrementing i value to iteretate loop.

                totalWage = totalempWorkHrs * totalWorkDays * empWagePerHrs;
                Console.WriteLine("Employee total wage is: " + totalWage);
                Console.ReadLine();
            }
        }
    }
}