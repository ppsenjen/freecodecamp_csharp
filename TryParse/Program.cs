using System.Threading.Channels;

namespace try_catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool looping = true;

            while (looping)
                try
                {
                    Console.WriteLine("Enter a number");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(num);

                    looping = false;
                }

                //Adding the e keyword to return a more specific error message
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }

            Console.WriteLine("Goodbye!");
            Console.ReadLine();
        }

    }
}

