using System;
using System.Diagnostics;

namespace EmployeeWageComputation
{
    public class Program
    {
        //constants
        const int EMP_PER_HRS = 20;
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;
        const int WORKING_DAYS = 20;
        static void Main(string[] args)
        {
            //local variables
            int empHrs = 0;
            int empWage = 0;
            int day = 1;
            int totalEmpWage = 0;
            Console.WriteLine("Welcome to the Employee Wage Computation");

            //UC5- Calculating Wages  for a Month

            Random random = new Random();
            for (day = 1; day <= WORKING_DAYS; day++)
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
                Console.WriteLine("Day{0} Employee Wage is {1} ", day, empWage);
            }
            Console.WriteLine("\nTotal Employee Wages for {0} days is {1} ", (day - 1), totalEmpWage);
            Console.ReadLine();
        }
    }
}