using System;
using System.Collections.Generic;
using System.Text;

namespace variable
{
    internal class NestedIf
    {
        static void Main()
        {
            int age = 20;
            bool hasID = true;

            if (age >=18)
            {
                if (hasID)
                {
                    Console.WriteLine("You can vote");
                }
            }
        }
    }
}
