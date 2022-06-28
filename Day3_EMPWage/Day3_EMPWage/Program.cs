using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_EMPWage
{
    internal class Program
    {
        public const int fullTime = 1;
        public const int partTime = 2;

        public static int computeEmpWage(string company, int empRatePerHour, int MaximumHoursPerMonth, int numOfWorkingDays)
        {
            int empHrs = 0;
            int totalWorkingDays = 0;
            int totalEmpHrs = 0;
            while (totalEmpHrs <= MaximumHoursPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case fullTime:
                        empHrs = 8;
                        break;
                    case partTime:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs = totalEmpHrs + empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + " Emp Hrs : " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp wage for company : " + company + " is: " + totalEmpWage);
            return totalEmpWage;

        }
        static void Main(string[] args)
        {
            computeEmpWage("Flipcart", 20,2,10);
            computeEmpWage("Dmart", 10, 4, 20);
        }
    }
}
