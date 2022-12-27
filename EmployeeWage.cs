using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class EmployeeAttendance
    {
        public static void CheckAttendance()
        {
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            int IS_PART_TIME = 2;
            int NUM_OF_WORKING_DAYS = 20;
            int MAX_HRS_IN_MONTH = 100;

            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            int totalEmpHrs = 0;
            int totalWorkingdays = 0;

            while(totalEmpHrs<=MAX_HRS_IN_MONTH && totalWorkingdays<NUM_OF_WORKING_DAYS)
            {
                totalWorkingdays++;
                Random random = new Random();
                int empCheck = random.Next(3);

                if (empCheck == IS_FULL_TIME)
                {
                    //Console.WriteLine("Employee is Present");
                    empHrs = 8;
                }
                else if (empCheck == IS_PART_TIME)
                {
                    //Console.WriteLine("Employye is Part time");
                    empHrs = 4;
                }
                else
                {
                    // Console.WriteLine("Employee is Absent");
                    empHrs = 0;
                }

                totalEmpHrs += empHrs;
                Console.WriteLine("DAy# " + totalWorkingdays + " hours is " + empHrs);
                
            }
            totalEmpWage = totalEmpHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("The Employee Total Wage is " + totalEmpWage);
          
        }
    }
}
