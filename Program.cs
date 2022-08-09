using System.Collections;
using System.Collections.Generic;

namespace EmployeeWageComputationProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            Console.Write("Enter No. Of Company = ");
            int num = Convert.ToInt32(Console.ReadLine());
            List<EmpWageBuilderUC11> list = new List<EmpWageBuilderUC11>();

            for (int i = 0; i < num; i++)
            {
                list.Add(new EmpWageBuilderUC11());
                list[i].CompanyBuilder((i + 1));
                list[i].GetAttendance();
                list[i].CalculateWage();
            }
        }
    }
}