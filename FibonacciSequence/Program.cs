using System;

namespace FibonacciSequence
{
    class Program
    {
        // Implementation Fibonacci Sequence in C# (.NET Core)

        static void Main(string[] args)
        {
            var random = new Random();

            Console.Write("Please Enter Number for Fibonacci Calculation : ");
            int number = int.Parse(Console.ReadLine());
            
            var result = FibonacciCalculator(number);

            Console.WriteLine(result);

            Console.ReadKey();
        }

        private static int FibonacciCalculator(int number)
        {
            if (number <= 1)
            {
                return number;
            }

            return FibonacciCalculator(number - 1) + FibonacciCalculator(number - 2);
        }
    }
}
