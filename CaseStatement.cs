using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_EmployeeWageProblem
{
    public class CaseStatement
    {
        public static void CalEmployeeWageUsingCaseStatement(Random random,int is_full_time, int empHrs, int empwage, int emp_rate_per_hour)
        {
            int empCheck = random.Next(3);

            switch (empCheck) {
                case 0:
                    empHrs = 0;
                    Console.WriteLine("Emloyee is absent ");
                    break;
                case 1:
                    empHrs = 8;
                    Console.WriteLine("Employee is present full time.");
                    break;
                case 2:
                    empHrs = 4;
                    Console.WriteLine("Employee is present part time.");
                    break;
            }
            empwage = empHrs * emp_rate_per_hour;
            Console.WriteLine("Employee wage is : " + empwage );

               
        }
    }
}
