using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_EmployeeWageProblem
{
    public class PartTimeWage_UC3
    {
        public static void CalcPartTimeWage(Random random, int is_full_time, int empHrs,int is_part_time,int empwage,int emp_rate_per_hour)
        {
            int empCheck = random.Next(3);

            if (empCheck == is_full_time )
            {
                empHrs = 8;
                Console.WriteLine("Employee is present full time.");
            }
            else if (empCheck == is_part_time)
            {
                empHrs = 4;
                Console.WriteLine("Employee is present part time.");
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("Employee is absent.");
            }
            empwage = empHrs * emp_rate_per_hour ;

            Console.WriteLine("Employee wage is : "+ empwage);
            

        }


    }
}
