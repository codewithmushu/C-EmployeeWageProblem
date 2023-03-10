using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_EmployeeWageProblem
{
    public class EmpWageFor100Hrs_UC6
    {
        public static void CalcEmpWageFor100Hrs(Random random, int total_work_hrs,int totaldaysworked, int is_full_time,int empHrs,int empwage_fulltime,int emp_rate_per_hour,int fulltimewage,int is_part_time,int empwage_parttime,int parttimewage, int monthlywage)
        {
            while (total_work_hrs < 100 && totaldaysworked < 20 )
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

                total_work_hrs += empHrs;
                totaldaysworked++;
                monthlywage = fulltimewage + parttimewage;
                
            }
        }
    }
}
