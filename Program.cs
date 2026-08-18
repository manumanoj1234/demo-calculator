using System;

namespace DemoCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 4;
            //int c = 10;
            double sum = Calculator.Add(a, b);
            double diff = Calculator.Sub(a, b);
            double multi = Calculator.Multi(a, b);
            double div = Calculator.Div(a, b);

            Console.WriteLine($"Add({a}, {b}) = {sum}");
            Console.WriteLine($"Sub({a}, {b}) = {diff}");
            Console.WriteLine($"Multi({a}, {b}) = {multi}");
            Console.WriteLine($"Div({a}, {b}) = {div}");
        }
    }
}
