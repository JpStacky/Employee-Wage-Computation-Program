namespace EmployeeWageComputationProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            Console.Write("Enter No. Of Company = ");
            int num = Convert.ToInt32(Console.ReadLine());

            EmpWageBuilderUC9[] empWageBuilderUC9 = new EmpWageBuilderUC9[num];
            for (int i = 0; i < num; i++)
            {
                empWageBuilderUC9[i] = new EmpWageBuilderUC9();
                empWageBuilderUC9[i].CompanyBuilder(num);
            }
        }
    }
}