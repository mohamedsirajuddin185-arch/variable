using System;
using System.Collections.Generic;
using System.Text;

namespace variable
{
    internal class Switchif
    {
        static void Main()
        {
            int choice = 2;
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Add Employee");
                    break;
                case 2:
                    Console.WriteLine("View Employee");
                    break;
                case 3:
                    Console.WriteLine("Delete Employee");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                        break;
            }
        }
    }
}
