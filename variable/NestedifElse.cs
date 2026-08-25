using System;
using System.Collections.Generic;
using System.Text;

namespace variable
{
    internal class NestedifElse
    {
        static void Main()
        {
            int age = 20;
            bool hasID = false;
            if (age >= 18)
            {
                if (hasID)
                {
                    Console.WriteLine("You can vote");
                }
                else
                {
                    Console.WriteLine("You need an ID to vote");
                }
            }
            else
            {
                Console.WriteLine("You are too young to vote");
            }
        }
    }
}
