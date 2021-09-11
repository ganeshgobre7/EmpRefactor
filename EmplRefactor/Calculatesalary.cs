using System;
using System.Collections.Generic;
using System.Text;

namespace EmplRefactor
{
    class Calculatesalary
    {
        int empPresent = 1;
        int full_Time = 8;
        int part_Time = 4;
        int per_Hour_Sal = 20;
        int one_Day_Sal = 0;
        public void check()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);

            switch (empCheck)
            {
                case 1:
                    one_Day_Sal = full_Time * per_Hour_Sal;
                    Console.WriteLine("Full time Employee ==> One Day Salary is :" + one_Day_Sal);
                    break;

                case 2:
                    one_Day_Sal = part_Time * per_Hour_Sal;
                    Console.WriteLine("Full time Employee ==> One Day Salary is :" + one_Day_Sal);
                    break;

                case 3:
                    Console.WriteLine("Employee is Absent");
                    break;
            }
                       
        }
    }
}
