using System.Collections;
using System.Collections.Generic;

namespace EmployeeWageComputationProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            EmpWageBuilderUC14 empWageBuilderUC14 = new EmpWageBuilderUC14();
            empWageBuilderUC14.GetValues();
            empWageBuilderUC14.GetAttendance();
            empWageBuilderUC14.DisplayDailyWage();
            empWageBuilderUC14.TotalWage();
        }
    }
}