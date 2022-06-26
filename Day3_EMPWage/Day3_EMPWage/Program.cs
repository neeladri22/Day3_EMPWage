using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_EMPWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateDailyEmployeeWage();
        }
        public static void CalculateDailyEmployeeWage() {

            Console.WriteLine("Calculate the daily Employee wage");
            Random random = new Random();
            int number = random.Next(0, 2);
            int wagePerHour = 20;
            int fullyDayHour = 8;
            int totalWage = 0;


            if (number == 0)
            {
                Console.WriteLine("Employee is Absent");
            }
            else 
            {
                Console.WriteLine("Employee is Present");
                totalWage = wagePerHour * fullyDayHour;
                Console.WriteLine("Employee's total wage is :"+ totalWage);

            }
        }
    }
}
