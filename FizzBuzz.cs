using System;

class Program
{
    static void Main(string[] args)
    {
        FizzBuzz(100); // Example usage with upto = 16
    }

    static void FizzBuzz(int upto)
    {
        for (int i = 1; i < upto; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}
