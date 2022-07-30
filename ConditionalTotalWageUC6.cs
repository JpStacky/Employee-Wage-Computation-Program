using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProgram
{
    internal class ConditionalTotalWageUC6
    {
        static int wage_Per_Hour = 20;
        static int full_Time_Hour = 8;
        static int part_Time_Hour = 4;
        static int work_Hour = 0;
        static int total_Wage;
        static int number_Of_Days = 0;
        public static void getAttendance()
        {
            // 0 for Absent
            // 1 for Present
            // 2 for PartTime
            Random random = new Random();
            
            while (true)
            //for (int i = 0; i < 20 && work_Hour < 100; i++)
            {
                ++number_Of_Days;
                int attendance = random.Next(3);
                if (attendance == 0)
                {
                    Console.WriteLine("Employee is Absent");
                    work_Hour += 0;
                }
                else if (attendance == 2)
                {
                    Console.WriteLine("Part Time Employee");
                    work_Hour += part_Time_Hour;
                }
                else
                {
                    Console.WriteLine("Employee is Present");
                    work_Hour += full_Time_Hour;
                }
                if (number_Of_Days == 20)
                {
                    Console.WriteLine("No. of Days Limit Reached");
                    break;
                }
                if (work_Hour >= 100)
                {
                    Console.WriteLine("Work Hour Limit Reached");
                    break;
                }

            }
            calculateWage();
        }
        public static void calculateWage()
        {
            total_Wage = work_Hour * wage_Per_Hour;
            Console.WriteLine("No. of Days Worked = "+number_Of_Days);
            Console.WriteLine("Total Work Hour = "+work_Hour);
            Console.WriteLine("Monthly Wage is = " +total_Wage);
        }
    }
}
