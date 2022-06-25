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
            
        }
        public static void CheckEmployeePresentOrAbsent() {

            Console.WriteLine("Welcome to Employee pay roll");
            Random random = new Random();
            int number = random.Next(0, 2);

            if (number == 0)
            {
                Console.WriteLine("Employee is Absent");
            }
            else {
                Console.WriteLine("Employee is Present");
            }
        }
    }
}
