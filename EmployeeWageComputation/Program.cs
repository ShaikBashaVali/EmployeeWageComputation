using System;
using System.Diagnostics;

namespace EmployeeWageComputation
{
    public class Program
    {
        static void Main(string[] args)
        {
            //local variables
            int empHrs = 0;
            int empWage = 0;
            //constants
            const int EMP_PER_HRS = 20;
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;

            Console.WriteLine("Welcome to the Employee Wage Computation");

            //UC4- Using Switch Case Statement
            Random random = new Random();
            int empAttendence = random.Next(0, 3);//0,1,2
            switch (empAttendence)
            {
                case IS_FULL_TIME:
                    empHrs = 8;
                    Console.WriteLine("Employee is Full Time Present");
                    break;
                case IS_PART_TIME:
                    empHrs = 4;
                    Console.WriteLine("Employee is Part Time Present");
                    break;
                default:
                    empHrs = 0;
                    Console.WriteLine("Employee is Absent");
                    break;
            }
            empWage = empHrs * EMP_PER_HRS;
            Console.WriteLine("Employee Wage is : " + empWage);
            Console.ReadLine();
        }
    }
}