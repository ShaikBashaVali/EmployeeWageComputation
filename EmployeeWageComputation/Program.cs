using System;
using System.Diagnostics;

namespace EmployeeWageComputation
{
    public class EmpWageBuilder
    {
        //constants
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public string company;
        public int maxWorkingDays, maxWorkingHrs, empPerHrs;
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="company"></param>
        /// <param name="empPerHrs"></param>
        /// <param name="maxWorkingDays"></param>
        /// <param name="maxWorkingHrs"></param>
        public EmpWageBuilder(string company, int empPerHrs, int maxWorkingDays, int maxWorkingHrs)
        {
            this.company = company;
            this.maxWorkingDays = maxWorkingDays;
            this.maxWorkingHrs = maxWorkingHrs;
            this.empPerHrs = empPerHrs;
        }
        public void ComputeEmpWage()
        {
            //local variables
            int empHrs = 0, empWage = 0, day = 1, totalEmpWage = 0, totalEmpHrs = 0;

            //UC9- Save the Total Wage for Each Company
            Random random = new Random();
            while (day <= maxWorkingDays && totalEmpHrs <= maxWorkingHrs)
            {
                int empAttendence = random.Next(0, 3);//0,1,2
                switch (empAttendence)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * empPerHrs;
                totalEmpWage = totalEmpWage + empWage;
                day++;
                totalEmpHrs = totalEmpHrs + empHrs;
            }
            Console.WriteLine("Total Employee Wage for {0} {1} days: {2} and totalHrs: {3} ", company, (day - 1), totalEmpWage, totalEmpHrs);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee Wage Computation\n.........................................\n");
            EmpWageBuilder tcs = new EmpWageBuilder("TCS", 25, 10, 20);
            tcs.ComputeEmpWage();
            EmpWageBuilder capgemini = new EmpWageBuilder("Capgemini", 25, 20, 30);
            capgemini.ComputeEmpWage();
            EmpWageBuilder wipro = new EmpWageBuilder("Wipro", 35, 30, 45);
            wipro.ComputeEmpWage();
        }
    }
}