using System;
using System.Collections.Generic;
using System.Text;

namespace EmplRefactor
{
    class Calculatesalary
    {
        int empPresent = 1;
        int empAbsent = 2;
        int one_Day_Sal = 0;
        int per_Hour_Sal = 20;
        int no_Of_Days = 20;
        int total_Sal = 0;
        int empHours = 0;
        int total_Work_Hours = 0;
        int total_Max_Hours = 100;
        int day = 1;
        public void check()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);

            while (day <= no_Of_Days && total_Work_Hours<=total_Max_Hours)
            {
                switch(empCheck)
                {
                    case 1:
                        empHours = 8;
                        break;

                    case 2:
                        empHours = 4;
                        break;

                    case 3:
                        empHours = 0;
                        break;                      
                }
                day++;
                one_Day_Sal = empHours * per_Hour_Sal;               
                total_Work_Hours = empHours + total_Work_Hours;
            }
            total_Sal = total_Work_Hours * per_Hour_Sal;
            Console.WriteLine("Total Salary of Months :" + total_Sal);
            Console.WriteLine("Total Hours of Months :" + total_Work_Hours);
        }
    }
}
