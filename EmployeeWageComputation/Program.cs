using System;

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

            //UC3- Add Part time Employee and Wage
            Random random = new Random();
            int empAttendence = random.Next(0, 3);//0,1,2
            if (empAttendence == IS_FULL_TIME)
            {
                empHrs = 8;
                Console.WriteLine("Employee is Full Time Present");
            }
            else if (empAttendence == IS_PART_TIME)
            {
                empHrs = 4;
                Console.WriteLine("Employee is Part Time Present");
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("Employee is Absent");
            }
            empWage = empHrs * EMP_PER_HRS;
            Console.WriteLine("Employee Wage is :" + empWage);
            Console.ReadLine();
        }
    }
}