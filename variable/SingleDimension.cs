using System;
using System.Collections.Generic;
using System.Text;

namespace variable
{
    internal class SingleDimension
    {
        static void Main()
        {
            int r, i;
            Console.WriteLine("enter row size of array");
            r = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[r];
            Console.WriteLine("enter array elements");
            for (i = 0; i< r; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("entered array elements are");
            for (i = 0; i< r;i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
