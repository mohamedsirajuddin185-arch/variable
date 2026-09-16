using System;
using System.Collections.Generic;
using System.Text;

namespace variable
{
    public class Smallestnum
    {
        static void Main()
        {
            int[] numbers = { 10, 20, 7, 3, 23 };
            int min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                    min = numbers[i];
            }
            Console.WriteLine("Smallest numbers is: " + min);
        }
    }
}
