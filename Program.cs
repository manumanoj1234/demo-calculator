using System;

namespace DemoCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 4;

            int sum = Calculator.Add(a, b);
            
            Console.WriteLine($"Add({a}, {b}) = {sum}");
            Console.WriteLine($"Subtract({a}, {b}) = {diff}");
        }
    }
}
