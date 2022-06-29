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
            EmpWage empWage = new EmpWage();
            empWage.addCompanyEmpwage("Dmart", 20, 100, 20);
            empWage.addCompanyEmpwage("Tata", 20, 120, 23);
            empWage.computeEmpWage();

        }
    }
}
