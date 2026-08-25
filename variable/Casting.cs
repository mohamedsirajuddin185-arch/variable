using System;
using System.Collections.Generic;
using System.Text;

namespace variable
{
    internal class Casting
    {
        static void Main(string[] args)
        {
            double d = 101.222;
            int i;
            i = Convert.ToInt32(d);
            Console.WriteLine("the value of d is : " + d);
            Console.WriteLine("the value of i is : " + i );
            Console.ReadLine();
        }
    }
}
