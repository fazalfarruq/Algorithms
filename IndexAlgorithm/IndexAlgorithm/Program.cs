using System;

namespace IndexAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sortedArray = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37,
        41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            bool ct = true;
            int min = 0;
            int max = sortedArray.Length - 1;
            int guess = 0;
            Console.WriteLine("Enter a Prime between 2 and 23");
            var input = Convert.ToInt16(Console.ReadLine());
            int counter = 0;
            

            while (ct)
            {

                guess = (min + max) / 2;
                var temp = sortedArray[guess];
                ++counter;
                if (input == temp)
                {
                    Console.WriteLine($"We found the index of the prine it is {guess}");
                    Console.WriteLine($"Number of tries is {counter}");
                    ct = false;
                }
                if (input < temp)
                {

                    max = guess - 1;
                    continue;
                }

                if (input > temp)
                {
                    min = guess + 1;
                }


            }
            Console.ReadLine();

        }
    }
}
