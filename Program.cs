namespace EmployeeWageComputationProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Console.WriteLine("Wage Computation is based on Full Time 8 Hrs and Half Time 4 Hrs.");


            //No. of company
            Console.Write("Enter the number of Company = ");
            int no_Of_Company = Convert.ToInt32(Console.ReadLine());

            //Declaring array with the size of no of company
            UserInputUC8[] cwm = new UserInputUC8[no_Of_Company];

            for (int i = 0; i < no_Of_Company; i++)
            {
                Console.WriteLine("\nEnter Values for Company " + (i+1));
                Console.Write("Enter Wage Per Hour = ");
                int wage_Per_Hour = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Total Working Days Per Month = ");
                int no_Of_Days_Per_Month = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Total Working Hour Per Month = ");
                int work_Hour_Per_Month = Convert.ToInt32(Console.ReadLine());
                
                //Calling Constructor for value initialisation
                cwm[i] = new UserInputUC8(wage_Per_Hour, no_Of_Days_Per_Month, work_Hour_Per_Month);
            }
            for (int i = 0; i < no_Of_Company; i++)
            {
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("Displaying Attendence and Wage for Company " + (i+1));
                cwm[i].getAttendance();
            }
        }
    }
}