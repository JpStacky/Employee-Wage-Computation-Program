using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProgram
{
    public class EmpWageBuilder
    {
        char choice;
        float wage_Per_Hour;
        int full_Time_Hour = 8;
        int count_Full_Time = 0;
        int part_Time_Hour = 4;
        int count_Part_Time = 0;
        int count_Work_Hour = 0;
        int count_Number_Of_Day = 0;
        int work_Hour_Per_day;
        int work_Day_Per_Month;
        int count_No_Of_Absent = 0;
        int work_Hour_Per_Month;
        float[] daily_Wage;

        public void GetValues()
        {
            Console.Write("Enter Employe Wage Per Hour = ");
            wage_Per_Hour = float.Parse(Console.ReadLine());
            Console.Write("Enter No. Of Working Days Per day = ");
            work_Day_Per_Month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Total Working Hour Per day = ");
            work_Hour_Per_Month = Convert.ToInt32(Console.ReadLine());

            daily_Wage = new float[work_Day_Per_Month];             //to store daily wage
        }
        public void GetAttendance()
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
                    daily_Wage[count_Number_Of_Day] = 0;
                }
                else if (attendance == 2)
                {
                    //Console.WriteLine("Part Time Employee");
                    count_Work_Hour += part_Time_Hour;
                    ++count_Part_Time;
                    daily_Wage[count_Number_Of_Day] = count_Work_Hour * wage_Per_Hour;
                }
                else
                {
                    //Console.WriteLine("Employee is Present");
                    count_Work_Hour += full_Time_Hour;
                    ++count_Full_Time;
                    daily_Wage[count_Number_Of_Day] = count_Work_Hour * wage_Per_Hour;
                }
                // Check for No. of Days per day condition reached
                if (count_Number_Of_Day == work_Day_Per_Month)
                {
                    Console.WriteLine("-----------------------------------------------------------------");
                    Console.WriteLine("No. of Days Limit Reached");
                    break;
                }
                // Check for No. of Hours per day condition reached
                if (count_Work_Hour >= work_Hour_Per_day)
                {
                    Console.WriteLine("-----------------------------------------------------------------");
                    Console.WriteLine("Work Hour Limit Reached");
                    break;
                }
            }
        }
        public void CalculateWage()
        {
            float total_Wage = count_Work_Hour * wage_Per_Hour;
            Console.WriteLine("No. of Part Time Days = " + count_Part_Time);
            Console.WriteLine("No. of Full Time Days = " + count_Full_Time);
            Console.WriteLine("No. of Days Absent = " + count_No_Of_Absent);
            Console.WriteLine("No. of Days Worked = " + count_Number_Of_Day);
            Console.WriteLine("Total Work Hour = " + count_Work_Hour);
            Console.WriteLine("dayly Wage is = " + total_Wage);
        }
        public void DisplayDailyWage()
        {
            for (int i = 0; i < work_Day_Per_Month; i++)
                Console.WriteLine("Day " + (i + 1) + " = " + daily_Wage[i]);
        }
    }
}
