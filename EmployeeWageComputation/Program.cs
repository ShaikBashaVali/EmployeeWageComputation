using System;
using System.Diagnostics;

namespace EmployeeWageComputation
{
    public class Program
    {
        //constants
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;
        const int EMP_PER_HRS = 20;
        const int MAX_WORKING_DAYS = 20;
        const int MAX_HRS_IN_MONTH = 100;

        static void Main(string[] args)
        {
            //local variables
            int empHrs = 0;
            int empWage = 0;
            int day = 1;
            int totalEmpWage = 0;
            int totalEmpHrs = 0;
            Console.WriteLine("Welcome to the Employee Wage Computation");

            //UC6- Calculating total Employee Wage when assume 100 hours and 20 days
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
    }
}