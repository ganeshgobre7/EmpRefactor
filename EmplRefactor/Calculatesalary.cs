using System;
using System.Collections.Generic;
using System.Text;

namespace EmplRefactor
{
    class Calculatesalary
    {
        int empPresent = 1;
        public void check()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            
            if (empCheck==empPresent)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
