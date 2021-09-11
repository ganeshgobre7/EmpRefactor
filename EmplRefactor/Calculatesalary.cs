using System;
using System.Collections.Generic;
using System.Text;

namespace EmplRefactor
{
    class Calculatesalary
    {
        
        int one_Day_Sal = 0;
        int per_Hour_Sal = 20;
        int total_Sal = 0;
        int empHours = 0;       
             
        public void check(int max_Work_Days, int max_Work_Hours, string comp_Name)
        {
            int day = 1;
            int total_Work_Hours = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);

            while (day <= max_Work_Days && total_Work_Hours<=max_Work_Hours)
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
            Console.WriteLine();
            total_Sal = total_Work_Hours * per_Hour_Sal;
            Console.WriteLine("Company Name is :" + comp_Name);
            Console.WriteLine("Total Wage For A Month is :" + total_Sal);
            Console.WriteLine("Total Working Hours in Month is:" + total_Work_Hours);
        }
    }
}
