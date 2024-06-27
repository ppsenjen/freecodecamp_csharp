using System;

class Program
{
    static void Main()
    {


        {
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            // Validate password length and digit presence
            if (password.Length >= 6)
            {
                Console.Write("Confirm your password: ");
                string confirmPassword = Console.ReadLine();

                if (password == confirmPassword)
                {
                    Console.WriteLine("Password successfully confirmed!");

                }
                else
                {
                    Console.WriteLine("Passwords do not match. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid password. It must have at least 6 characters and contain at least one digit.");

            }
        }
    }


}
