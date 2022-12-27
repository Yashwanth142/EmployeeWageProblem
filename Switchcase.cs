using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class Switchcase
    {

        public static void SwitchCase()
        {
           const int IS_FULL_TIME = 1;
           const int EMP_RATE_PER_HOUR = 20;
           const int IS_PART_TIME = 2;

            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            int empCheck = random.Next(3);

            switch(empCheck)
            {
                case IS_FULL_TIME:
                    empHrs=8; 
                    break;
                case IS_PART_TIME: 
                    empHrs=4;
                    break;
                default:
                    empHrs=0;
                    break;

            }

            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("The Employee Wage is " + empWage);
        }
    }
}
