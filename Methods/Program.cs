namespace methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage();
            PrintIntroduction();

            Console.Title = ReturnName();

            Console.ReadLine();

        }

        static void WelcomeMessage()
        {
            Console.WriteLine("Hello, World Pam!");


        }

        static void PrintIntroduction()
        {
            Console.WriteLine("pam");

        }
        static string ReturnName()
        {

            return "pam";

        }
    }
}
