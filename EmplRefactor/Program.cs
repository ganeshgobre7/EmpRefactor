using System;

namespace EmplRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Well-Come to Employee Wage Computation Program");
            Calculatesalary calculate = new Calculatesalary();
            calculate.check();
        }
    }
}
