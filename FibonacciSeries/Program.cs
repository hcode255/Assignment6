using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10; // Number of terms to generate

            Console.WriteLine("Fibonacci Series:");

            for (int i = 0; i < n; i++)
            {
                int fibonacciNumber = Fibonacci(i);
                Console.WriteLine(fibonacciNumber);
            }

            Console.ReadLine();
        }

        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}

