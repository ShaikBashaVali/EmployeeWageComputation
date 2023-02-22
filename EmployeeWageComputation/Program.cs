using System;
using System.Diagnostics;

namespace EmployeeWageComputation
{
    public class Program
    {
        //constants
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public static void ComputeEmpWage(string company, int empPerHrs, int maxWorkingDays, int maxWorkingHrs)
        {
            //local variables
            int empHrs = 0;
            int empWage = 0;
            int day = 1;
            int totalEmpWage = 0;
            int totalEmpHrs = 0;

            //UC8- Compute Employee Wage for Multiple Company
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
            Console.WriteLine("Welcome to the Employee Wage Computation \n........................................\n");
            ComputeEmpWage("TCS", 25, 10, 20);
            ComputeEmpWage("Capgemini", 25, 20, 30);
            ComputeEmpWage("Wipro", 35, 30, 45);
            Console.ReadLine();
        }
    }
}