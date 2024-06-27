namespace Exception_handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());


            }
            catch (Exception e)
            {


                Console.WriteLine($"Error: {e.Message}");
            }


        }
    }
}
