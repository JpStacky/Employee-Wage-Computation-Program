using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProgram
{
    internal class DailyWageUC2
    {
        static int wage_Per_Hour = 20;
        static int full_Time_Hour = 8;
        static int work_Hour=0;
        static int total_Wage;

        public static void getAttendance()
        {
            // 0 for Absent and 1 for Present
            Random random = new Random();
            int attendance = random.Next(2);
            if (attendance == 0)
            {
                Console.WriteLine("Employee is Absent");
                work_Hour += 0;
            }
            else
            {
                Console.WriteLine("Employee is Present");
                work_Hour += full_Time_Hour;
            }
            calculateWage();
        }
        public static void calculateWage()
        {
            total_Wage = work_Hour * wage_Per_Hour;
            Console.WriteLine("Today Wage is "+total_Wage);
        }
    }
}
