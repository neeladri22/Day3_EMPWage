using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_EMPWage
{
    internal class EmpWageBuilderObject
    {
        public const int fullTime = 1;
        public const int partTime = 2;

        private string company;
        private int empRatePerHour;
        private int maxHoursPerMonth;
        private int numOfWorkingDays;
        private int totalEmpWage;

        public EmpWageBuilderObject(string company, int empRatePerHour, int maxHoursPerMonth, int numOfWorkingDays) {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void computeEmpWage() {
            int empHrs = 0;
            int totalWorkingDays = 0;
            int totalEmpHrs = 0;
            while (totalEmpHrs <= this.maxHoursPerMonth && totalWorkingDays < this.numOfWorkingDays)
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
            int totalEmpWage = totalEmpHrs * this.empRatePerHour;
            Console.WriteLine("Total Emp wage for company : " + company + " is: " + totalEmpWage);
        }
        public string toString()
        {
            return "Total Employee wages for company " + this.company + " is : " + this.totalEmpWage;
        }
    }
}
