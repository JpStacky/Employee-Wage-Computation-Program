using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProgram
{
    public class EmpWageBuilderUC10
    {
        char choice;
        public void CompanyBuilder(int no_Of_Company)
        {
            int num = no_Of_Company;
            CompanyEmpWageUC10[] wageCalculator = new CompanyEmpWageUC10[num];
            float[] total_Wage = new float[num];

            for (int i = 0; i < num; i++)
            {
                wageCalculator[i] = new CompanyEmpWageUC10();
                Console.WriteLine("Enter Values for Wage Calculation of Company " + (i + 1) + ".");
                Console.Write("Enter Employe Wage Per Hour = ");
                float wage = float.Parse(Console.ReadLine());
                wageCalculator[i].wage_Per_Hour = wage;
                Console.Write("Enter No. Of Working Days Per Month = ");
                int month = Convert.ToInt32(Console.ReadLine());
                wageCalculator[i].no_Of_Days_Per_Month = month;
                Console.Write("Enter Total Working Hour Per Month = ");
                int total_Hour = Convert.ToInt32(Console.ReadLine());
                wageCalculator[i].work_Hour_Per_Month = total_Hour;
                wageCalculator[i].getAttendance();
                total_Wage[i] = wageCalculator[i].calculateWage();                 //Saving total wage for each company
            }
            for (int i = 0; i < num; i++)
                Console.WriteLine("Total Wage for Company " + (i + 1) + " =" + total_Wage[i]);
        }
    }
}
