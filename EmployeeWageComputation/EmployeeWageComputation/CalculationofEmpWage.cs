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
        /// UC 2
        /// </summary>
        public static void EmpWageCompute() // Calling Static method 
        {
            int fulltime = 2;
            int parttime = 1;
            int totalWage = 0;
            int empWageHrs = 0;
            int empWagePerHrs = 20;
            Random random = new Random();           //Creating Object of Random Class
            int EmpAttendence = random.Next(0, 3); //Generating random number between 0 and 2

            if (EmpAttendence == fulltime)  // Using if else statement to check the condition
            {
                Console.WriteLine("Employee is Present");
                empWageHrs = 8;
            }
            else if (EmpAttendence == parttime)
            {
                Console.WriteLine("Employee is present");
                empWagePerHrs = 4;
            }
            else
                Console.WriteLine("Employee is absent");

            totalWage = empWageHrs * empWagePerHrs;
            Console.WriteLine("Employee total Daily Wage: " + totalWage);

        }
        }
    }
}