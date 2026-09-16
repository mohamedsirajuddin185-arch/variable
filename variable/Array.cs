

namespace variable;

public class Array
{
    static void Main ()
    {
        int[] numbers = { 10, 25, 7, 50, 32 , 44 , 66 , 100 };
        int max = numbers[0];
        int small = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        Console.WriteLine("Largest number is: " + max);



        //Smallest number -----git PR updated
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < small)
            {
                small = numbers[i];
            } 
        }
        Console.WriteLine($"Smallest Number is : {small} ");

    }
}
