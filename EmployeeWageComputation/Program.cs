using System;
using System.Diagnostics;

namespace EmployeeWageComputation
{
    public class Program
    {
        //constants
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_PER_HRS = 20;
        public const int MAX_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 100;

        public static void ComputeEmpWage()
        {
            //local variables
            int empHrs = 0;
            int empWage = 0;
            int day = 1;
            int totalEmpWage = 0;
            int totalEmpHrs = 0;
            Console.WriteLine("Welcome to the Employee Wage Computation");

            //UC7- Compute Employee Wage Using Class Methods
            Random random = new Random();
            while (day <= MAX_WORKING_DAYS && totalEmpHrs <= MAX_HRS_IN_MONTH)
            {
                int empAttendence = random.Next(0, 3);//0,1,2
                switch (empAttendence)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        Console.WriteLine("\nEmployee is Full Time Present");
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        Console.WriteLine("\nEmployee is Part Time Present");
                        break;
                    default:
                        empHrs = 0;
                        Console.WriteLine("\nEmployee is Absent");
                        break;
                }
                empWage = empHrs * EMP_PER_HRS;
                totalEmpWage = totalEmpWage + empWage;
                Console.WriteLine("Day{0} Employee Wage is {1} and totalHrs: {2} ", day, empWage, totalEmpHrs);
                day++;
                totalEmpHrs = totalEmpHrs + empHrs;
            }
            Console.WriteLine("\nTotal Employee Wage for {0} days: {1} and totalHrs: {2} ", (day - 1), totalEmpWage, totalEmpHrs);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            ComputeEmpWage();
        }
    }
}