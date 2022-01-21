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
        // static method 
        public static void WageCompute()
        {

            int present = 1;
            Random random = new Random();           //Creating Object of Random Class
            int empAttendence = random.Next(0, 2); //Generating random number between 0 and 1


            if (empAttendence == present) //Checking condition using if else statement
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is not Present");
            }
        }
    }
}
