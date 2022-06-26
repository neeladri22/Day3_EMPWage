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
        public const int wagePerHour = 20;
        public const int NumberOfWorkingDays = 20;
        public const int MaxHoursInMonth = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("Calculating employee Wages for a Month");
            int empHours = 0;
            int empwage = 0;
            int totalWage = 0;
           
            for (int day=0;day<NumberOfWorkingDays;day++) 
            {
                Random random = new Random();
                int number = random.Next(0, 3);
                switch (number) 
                {
                case IsAbsent:
                        empHours = 0;
                        break;

                case IsFullTime:
                        empHours = 8;
                        break;

                case IsPartTime:
                        empHours = 4;
                        break;

                }
                empwage = empHours * wagePerHour;
                totalWage = totalWage + empwage;
                Console.WriteLine("Employee wage is :"+ empwage);
            }
            Console.WriteLine("total Employee wage is :" + totalWage);
        }
    }
}
