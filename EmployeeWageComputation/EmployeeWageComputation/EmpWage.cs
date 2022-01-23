using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public interface IComputeEnpWage
    {
        void AddCompany(string company, int empRatePerHr, int maxWorkingDays, int maxWorkingHrs);
        void GetWage();
        int CalWage(EmpWage emp);
    }
    public class EmpWage
    {
        public string company;
        public int empRatePerHr, maxWorkingDays, maxWorkingHrs, totalWage;
        // constructor to initialize variable
        public EmpWage(string company, int empRatePerHr, int maxWorkingDays, int maxWorkingHrs)
        {
            this.company = company;
            this.empRatePerHr = empRatePerHr;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHrs = maxWorkingHrs;
        }
        public void SetTotalWage(int totalWage)
        {
            this.totalWage = totalWage;
        }
    }
}
