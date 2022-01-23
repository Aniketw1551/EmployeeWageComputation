using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class CalculationofEmpWage : IComputeEnpWage
    {
        /// <summary>
        /// UC 11
        /// Computing wage for employees of multiple companies using Interface approach
        /// </summary>
 
            //Constant variables    
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            //static variables
            static int empHrs = 0;
            int empWage;
            int days = 1;
            int empWorkingHrs = 0;
            EmpWage[] CompanyRecord = new EmpWage[5];
            public int numOfCompany = 0;
            public void AddCompany(string company, int empRatePerHr, int maxWorkingDays, int maxWorkingHrs)
            {
                EmpWage emp = new EmpWage(company, empRatePerHr, maxWorkingDays, maxWorkingHrs);
                this.CompanyRecord[this.numOfCompany] = emp;       //storing details in array with respecting index
                numOfCompany++;
            }
            public void GetWage()
            {
                //looping to get and set total wage for each index value
                for (int i = 0; i < numOfCompany; i++)
                {
                    int result = CalWage(this.CompanyRecord[i]);
                    this.CompanyRecord[i].SetTotalWage(result);
                }
            }

            public int CalWage(EmpWage emp)
            {
                int totalWage = 0;

                Random random = new Random();
                while (empWorkingHrs <= emp.maxWorkingHrs && days <= emp.maxWorkingDays)
                {

                    int randomInput = random.Next(0, 3);

                    GetWorkingHrs(randomInput);
                    empWage = emp.empRatePerHr * empHrs;
                    Console.WriteLine("Employee wage for DAy {0} is {1}", days, empWage);
                    totalWage += empWage;
                    empWorkingHrs += empHrs;

                    if (empWorkingHrs > emp.maxWorkingHrs)
                    {
                        empWorkingHrs = emp.maxWorkingHrs;
                        break;
                    }
                    days++;

                }
                Console.WriteLine("\nEmployee of company : {0} , Total wage is : {1} ", emp.company, totalWage);
                return totalWage;
            }

            //method to calculate working hours
            public static void GetWorkingHrs(int randomInput)
            {

                switch (randomInput)
                {
                    case FULL_TIME:
                        empHrs = 8;
                        break;
                    case PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
            }
        }
    }

