using System;

namespace FibonacciFazal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            for (int i = 1; i <= 6; i++)
            {
                Console.WriteLine($"{i} {FiboR(i)}");
            }

            Console.WriteLine("Call to Fibonacci Series with Recursion is done");
            Console.WriteLine("---------------------------");
            Console.WriteLine();

            FiboPlain(6);

            Console.WriteLine("Call to Fibonacci Series without Recursion is done");
            Console.WriteLine("---------------------------");
        }

        //Fibonaci is the sum of two numbers following each other and so on.. 0, 1, 1, 2, 3, 5, 8, 13...
        // that is Fn = F(n - 1) + F (n-2)
        static int FiboR(int n)
        {

            if (n <= 2)
            {
                return 1;
            }
            else
            {
                return FiboR(n - 1) + FiboR(n - 2);
            }
        }


        static void FiboPlain(int n) {

            int[] array = new int[n + 2];
            array[0] = 0;
            array[1] = 1;
            for (int i = 2; i <= n; i++) {
                array[i] = array[i - 1] + array[i - 2];
                Console.WriteLine($"{i} {array[i]}");
            }

        }
    }
}
