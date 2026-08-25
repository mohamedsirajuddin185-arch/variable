using System;
using System.Collections.Generic;
using System.Text;

namespace variable
{
    internal class Array
    {
        static void Main ()
        {
            int[] numbers = { 10, 25, 7, 50, 32 };
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine("Largest number is: " + max);
        }
    }
}
