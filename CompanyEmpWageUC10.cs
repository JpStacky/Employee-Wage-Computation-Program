﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProgram
{
    public class CompanyEmpWageUC10
    {
        public float wage_Per_Hour;
        int full_Time_Hour = 8;
        int count_Full_Time = 0;
        int part_Time_Hour = 4;
        int count_Part_Time = 0;
        int count_Work_Hour = 0;
        int count_Number_Of_Day = 0;
        public int no_Of_Days_Per_Month;
        public int work_Hour_Per_Month;
        int count_No_Of_Absent = 0;

        public void getAttendance()
        {
            // 0 for Absent
            // 1 for Present
            // 2 for PartTime
            Random random = new Random();

            while (true)
            {
                ++count_Number_Of_Day;
                int attendance = random.Next(3);
                if (attendance == 0)
                {
                    //Console.WriteLine("Employee is Absent");
                    count_Work_Hour += 0;
                    ++count_No_Of_Absent;
                }
                else if (attendance == 2)
                {
                    //Console.WriteLine("Part Time Employee");
                    count_Work_Hour += part_Time_Hour;
                    ++count_Part_Time;
                }
                else
                {
                    //Console.WriteLine("Employee is Present");
                    count_Work_Hour += full_Time_Hour;
                    ++count_Full_Time;
                }

                // Check for No. of Days per month condition reached
                if (count_Number_Of_Day == no_Of_Days_Per_Month)
                {
                    Console.WriteLine("-----------------------------------------------------------------");
                    Console.WriteLine("No. of Days Limit Reached");
                    break;
                }
                // Check for No. of Hours per month condition reached
                if (count_Work_Hour >= work_Hour_Per_Month)
                {
                    Console.WriteLine("-----------------------------------------------------------------");
                    Console.WriteLine("Work Hour Limit Reached");
                    break;
                }

            }
        }
        public float calculateWage()
        {
            float total_Wage = count_Work_Hour * wage_Per_Hour;
            Console.WriteLine("No. of Part Time Days = " + count_Part_Time);
            Console.WriteLine("No. of Full Time Days = " + count_Full_Time);
            Console.WriteLine("No. of Days Absent = " + count_No_Of_Absent);
            Console.WriteLine("No. of Days Worked = " + count_Number_Of_Day);
            Console.WriteLine("Total Work Hour = " + count_Work_Hour);
            Console.WriteLine("Monthly Wage is = " + total_Wage);
            return total_Wage;
        }
    }
}
