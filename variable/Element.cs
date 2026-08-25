using System;
using System.Collections.Generic;
using System.Text;

namespace variable
{
    internal class Element
    {
        static void Main()
        {
            int[] numbers = { 5, 10, 15, 20, 25 };
            int sum = 0;
            for (int i = 0; i < numbers.Length;i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine("Sum of array elemens is: " + sum);
        }
    }
}
