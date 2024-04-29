using System;

class Program
{
    static void Main(string[] args)
    {
        int number;
        bool isValid = false;

        Console.WriteLine("Enter an integer value between 5 and 10:");

        do
        {
            string input = Console.ReadLine();
            
            if (int.TryParse(input, out number) && number >= 5 && number <= 10)
            {
                isValid = true;
            }
            else
            {
                Console.WriteLine("Sorry, you entered an invalid number. Please try again.");
            }
        } while (!isValid);

        Console.WriteLine($"Your input value ({number}) has been accepted.");
    }
}
