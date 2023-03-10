using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_EmployeeWageProblem
{
    public class EmployeePresenty
    {
        public static void CalcEmployeePresenty(int is_full_time, Random random)
        {

            int empCheck = random.Next(2);

            if (empCheck == is_full_time)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}

