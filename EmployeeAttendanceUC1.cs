using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationProgram
{
    internal class EmployeeAttendanceUC1
    {
        //Generating Random Number To check Employee Attendance
        public static void getAttendance()
        {
            // 0 for Absent and 1 for Present
            Random random = new Random();
            int attendance = random.Next(2);
            if(attendance == 0)
                Console.WriteLine("Employee is Absent");
            else
                Console.WriteLine("Employee is Present");
        }

    }
}
