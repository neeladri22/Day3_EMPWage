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
            AddParttimeEmployeeAndWage();
        }
        public static void AddParttimeEmployeeAndWage() {

            Console.WriteLine("Add part time Employee wage");
            Random random = new Random();
            int number = random.Next(0, 3);
            int wagePerHour = 20;
            int fullyDayHour = 8;
            int partTimeHour = 4;
            int totalWage = 0;

            if (number == 0)
            {
                Console.WriteLine("Employee is Absent");
            }
            else if(number == 1)
            {
                Console.WriteLine("Employee is Present");
                totalWage = wagePerHour * fullyDayHour;
                Console.WriteLine("Full time Employee's total wage is :" + totalWage);
            }
            else 
            {
                Console.WriteLine("Employee is Present and Part time Employee");
                totalWage = wagePerHour * partTimeHour;
                Console.WriteLine("Part time Employee's total wage is :" + totalWage);
            }
        }
    }
}
