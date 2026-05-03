using System;

class Task1
{
    public static void Run()
    {
        Console.Write("Enter a positive integer:");

        int number;

        if (int.TryParse(Console.ReadLine(),out number) && number >= 0)
        {
            long factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine("Factorial of " + number + " is: " + factorial);
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}