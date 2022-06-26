using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_EMPWage
{
    internal class Program
    {
        public const int IsPartTime = 1;
        public const int IsFullTime = 2;
        public const int IsAbsent = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Calculating the Wages for a Month");
            int wagePerHour = 20;
            int fullyTimeHour = 8;
            int partTimeHour = 4;
            int totalWage = 0;
            int NumberOfWorkingDays = 20;

            for (int i=0;i<NumberOfWorkingDays;i++) 
            {
                Random random = new Random();
                int number = random.Next(0, 3);
                switch (number) 
                {
                    case IsAbsent:
                      Console.WriteLine("Employee is Absent");
                break;

                case IsFullTime:
                    Console.WriteLine("Employee is fulltime");
                totalWage =totalWage + wagePerHour * fullyTimeHour;
                Console.WriteLine("Full time Employee's total wage is :" + totalWage);
                break;

                case IsPartTime:
                    Console.WriteLine("Employee is Present and Part time Employee");
                totalWage = totalWage + wagePerHour * partTimeHour;
                Console.WriteLine("Part time Employee's total wage is :" + totalWage);
                break;

            }

            }               

        }
    }
}
