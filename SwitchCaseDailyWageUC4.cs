using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProgram
{
    internal class SwitchCaseDailyWageUC4
    {
        static int wage_Per_Hour = 20;
        static int full_Time_Hour = 8;
        static int part_Time_Hour = 4;
        static int work_Hour = 0;
        static int total_Wage;

        public static void getAttendance()
        {
            // 0 for Absent
            // 1 for Present
            // 2 for PartTime
            Random random = new Random();
            int attendance = random.Next(3);
            switch(attendance)
            {
                case 0:
                Console.WriteLine("Employee is Absent");
                work_Hour += 0;
                break;

                case 2:
                Console.WriteLine("Part Time Employee");
                work_Hour += part_Time_Hour;
                break;

                case 1:
                Console.WriteLine("Employee is Present");
                work_Hour += full_Time_Hour;
                break;

                default:
                    Console.WriteLine("Debug Code");
                    break;
            }
            calculateWage();
        }
        public static void calculateWage()
        {
            total_Wage = work_Hour * wage_Per_Hour;
            Console.WriteLine("Today Wage is " + total_Wage);
        }
    }
}
