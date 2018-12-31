using System;

namespace FactorialFazal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var n = 5;
            Console.WriteLine($"The Factorial of {n} without recursion is {FactorialPlain(n)}");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine($"The Factorial of {n} with *RECURSION is {FactorialR(n)}");
            Console.WriteLine();
        }

        static int FactorialPlain(int n)
        {
            int sum = n;
            for (int i = n - 1; i >= 1; i--)
            {
                sum = sum * i;
            }
            return sum;
        }

        static int FactorialR(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return n * FactorialR(n - 1);
            }

        }
    }
}
