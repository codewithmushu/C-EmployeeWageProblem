using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_EmployeeWageProblem
{
    public class EmpWageForMonth
    {
        public static void CalcEmpWageForMonth(Random random,int is_full_time, int is_part_time,int empHrs, int empwage_fulltime,int empwage_parttime,int emp_rate_per_hour, int working_days, int monthlywage, int total_work_Hrs, int fulltimewage, int parttimewage )
        {
           

            for (int day = 1; day <= 20; day++)
            {
                int empCheck = random.Next(3);
                

                if (empCheck == is_full_time)
                {
                    
                    empHrs = 8;
                    empwage_fulltime = empHrs * emp_rate_per_hour;
                    fulltimewage += empwage_fulltime;
                    Console.WriteLine("Employee is present full time.Employee wage is :" + empwage_fulltime);
                    
                }
                else if (empCheck == is_part_time)
                {
                    empHrs = 4;
                    empwage_parttime = empHrs * emp_rate_per_hour;
                    parttimewage += empwage_parttime;
                    Console.WriteLine("Employee is present part time. Employee wage is :" + empwage_parttime);

                }
                else
                {
                    empHrs = 0;
                    Console.WriteLine("Employee is absent.");
                }
               
            }
            monthlywage = fulltimewage + parttimewage;
            Console.WriteLine("Monthly wage of employee is : " + monthlywage);


        }
    }
}
