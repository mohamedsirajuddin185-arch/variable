using System;
using System.Collections.Generic;
using System.Text;

namespace variable
{
    internal class elseIf
    {
        static void Main()
        {
            int marks = 80;
            if (marks >= 90)
            {
                Console.WriteLine("Grade A");
            }
            else if (marks >= 75)
            {
                Console.WriteLine("Grade B");
            }
            else
            {
                Console.WriteLine("Grade C");
            }
        }
    }
}
