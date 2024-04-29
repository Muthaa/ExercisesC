using System;

class Program
{
    static void Main(string[] args)
    {
        string[] validRoles = { "administrator", "manager", "user" };
        string role;

        Console.WriteLine("Enter your role name (Administrator, Manager, or User):");

        bool isValid = false;

        do
        {
            role = Console.ReadLine().Trim().ToLower();

            foreach (string validRole in validRoles)
            {
                if (role == validRole)
                {
                    isValid = true;
                    break;
                }
            }

            if (!isValid)
            {
                Console.WriteLine("The role name that you entered is not valid. Enter your role name (Administrator, Manager, or User):");
            }

        } while (!isValid);

        Console.WriteLine($"Your input value ({role}) has been accepted.");
    }
}
