using System;

namespace EmplRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Well-Come to Employee Wage Computation Program");
            Calculatesalary calculate = new Calculatesalary();
            calculate.check(25, 150,"Tata");
            calculate.check(26, 120, "IBM");
            calculate.check(22, 100, "TCS");
            calculate.check(21, 120, "Wipro");
        }
    }
}
