using System.Collections;
using System.Collections.Generic;

namespace EmployeeWageComputationProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            DailyTotalWageUC13 dailyTotalWage = new DailyTotalWageUC13();
            dailyTotalWage.GetValues();
            dailyTotalWage.GetAttendance();
            dailyTotalWage.CalculateWage();
            dailyTotalWage.DisplayDailyWage();
        }
    }
}