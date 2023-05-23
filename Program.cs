using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 17; // The number to check

            bool isPrime = IsPrimeNumber(number);

            Console.WriteLine($"{number} is{(isPrime ? "" : " not")} a prime number.");

            Console.ReadLine();
        }

        static bool IsPrimeNumber(int number)
        {
            if (number <= 1)
                return false;

            if (number == 2)
                return true;

            if (number % 2 == 0)
                return false;

            int sqrt = (int)Math.Sqrt(number);

            for (int i = 3; i <= sqrt; i += 2)
           {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
