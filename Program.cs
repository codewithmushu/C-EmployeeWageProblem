using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_EmployeeWageProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage computation program.");

            int is_full_time = 1;
            int is_part_time = 2;
            int emp_rate_per_hour = 20;
            int working_days = 20;
            int total_work_hrs = 0;
            int totaldaysworked = 0;

            int empHrs = 0;
            int empwage_fulltime = 0;
            int empwage_part_time = 0;
            int monthlywage = 0;
            int fulltimewage = 0;
            int parttimewage = 0;

            Random random = new Random();

            //EmployeePresenty.CalcEmployeePresenty( is_full_time, random);
             UC2_Dailywage.CalcDailyWage(random,empHrs, empwage, emp_rate_per_hour, is_full_time);
            // PartTimeWage_UC3.CalcPartTimeWage(random, is_full_time, empHrs,is_part_time,empwage,emp_rate_per_hour);
            // CaseStatement.CalEmployeeWageUsingCaseStatement(random, is_full_time, empHrs,empwage,emp_rate_per_hour);
            //EmpWageForMonth.CalcEmpWageForMonth(random, is_full_time, is_part_time,empHrs,empwage_fulltime,empwage_part_time,emp_rate_per_hour,working_days, monthlywage ,total_work_hrs, fulltimewage, parttimewage );
            //EmpWageFor100Hrs_UC6.CalcEmpWageFor100Hrs(random, total_work_hrs,totaldaysworked,is_full_time,empHrs,empwage_fulltime,emp_rate_per_hour,fulltimewage,is_part_time,empwage_part_time,parttimewage,monthlywage  );
        }
    }
}
