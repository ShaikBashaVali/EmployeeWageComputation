using System;

namespace EmployeeWageComputation
{
    public class Program
    {
        static void Main(string[] args)
        {
            const int IS_FULL_TIME = 1;
            Console.WriteLine("Welcome to the Employee Wage Computation\n");

            //UC1- EmployeeAttendence
            Random random = new Random();
            int empAttendence = random.Next(0, 2);//0 or 1
            if (empAttendence == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Console.ReadLine();
        }
    }
}