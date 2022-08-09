
using System.Collections;

namespace EmployeeWageComputationProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            Console.Write("Enter No. Of Company = ");
            int num = Convert.ToInt32(Console.ReadLine());

            ArrayList array = new ArrayList();
            
            for (int i = 0; i < num; i++)
                array.Add(new EmpWageBuilderUC11());
        }
    }
}