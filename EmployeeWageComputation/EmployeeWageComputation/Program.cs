using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Welcome to EmployeeWageComputation program"); // printing message on console 
         CalculationofEmpWage empWage = new CalculationofEmpWage();
          empWage.EmpWageCompute(); // calling static method using class
            Console.ReadLine();
        }
    }
}
