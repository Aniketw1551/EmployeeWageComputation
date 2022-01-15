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
        /// UC 1
        /// </summary>
        public static void EmpWageCompute() // Calling Static method 
        {
            int present = 1;
            Random random = new Random();           //Creating Object of Random Class
            int EmpAttendence = random.Next(0, 2); //Generating random number between 0 and 1


            if (EmpAttendence == present)  // Using if else statement to check the condition
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is absent");

            }
        }
    }
}