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
        /// UC 5
        /// </summary>
        public static void EmpWageCompute() // Calling Static method 
        {
            const int FullTime = 2;
            const int PartTime = 1;
            const int empWagePerHrs = 20;
            const int empWorkPerMonth = 20;
            int empWageHrs = 0;
            int totalWage = 0;
            Random random = new Random();           //Creating Object of Random Class
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
            totalWage = empWorkPerMonth * empWageHrs * empWagePerHrs;
            Console.WriteLine("Employee total monthly wage is: " + totalWage);
            Console.ReadLine();
        }
    }
}