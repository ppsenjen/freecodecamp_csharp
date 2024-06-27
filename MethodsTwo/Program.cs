using System.ComponentModel.Design;

namespace methodstwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = PromptPassword();
            ConfirmPassword(password);

            Console.WriteLine("Hello, World!");
        }


        //method to prompt user to enter  a password
        static string PromptPassword()
        {

            Console.WriteLine("Enter your password: ");
            string password = Console.ReadLine();
            return password;

        }

        //method for password confrmation
        static void ConfirmPassword(string password)
        {
            for (int attempts = 0; attempts < 3; attempts++)
            {
                Console.WriteLine("Confrm your password");
                string ConfirmPassword = Console.ReadLine();

                if (password == ConfirmPassword)
                {
                    Console.WriteLine("Password Confirmed");
                    Console.WriteLine(password);
                    return;
                }
                else
                {
                    Console.WriteLine("Password do not Match try again");
                }
            }
            Console.WriteLine("Passwords do not match after two attempts");

        }
        //printing the password using foreach
        static void PrintPassword(string password)
        {
            Console.WriteLine("Your password is: ");
            foreach (char character in password)
            {

                Console.WriteLine(character);
            }
            Console.WriteLine();
        }



    }
}
