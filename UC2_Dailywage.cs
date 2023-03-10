
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_EmployeeWageProblem
{
    public class UC2_Dailywage
    {
        public static void CalcDailyWage(Random random, int is_full_time, int empHrs, int emp_rate_per_hour, int empwage)
        {
            int empCheck = random.Next(2);

            if ( empCheck == is_full_time )
            {
                empHrs = 8;
                Console.WriteLine("Employee is present");
            } 
            else
            {
                empHrs = 0;
                Console.WriteLine("Employee is absent");
            }
            empwage = empHrs * emp_rate_per_hour;

            Console.WriteLine("Employee wage is : " + empwage);

        }
    }
}

