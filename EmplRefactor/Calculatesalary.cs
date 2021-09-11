using System;
using System.Collections.Generic;
using System.Text;

namespace EmplRefactor
{
    class Calculatesalary
    {
        int empPresent = 1;
        int full_Time = 8;
        int per_Hour_Sal = 20;
        int one_Day_Sal = 0;
        public void check()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            
            if (empCheck==empPresent)
            {
                one_Day_Sal = full_Time * per_Hour_Sal;
                Console.WriteLine("Full time employee One Day Salary is :"+ one_Day_Sal); ;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
