namespace lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //with lists you can add numbers 
            List<int> listNumbers = new List<int>()
            { 
                //with lists you can add numbers 
                //arrays when you add numbers you will get an error 
            1, 2, 3, 4, 5

            };

            //promting the user to enter a numbers
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                //listNumbers.Add(num);
            }

            //printing numbers to screen
            Console.WriteLine();
            foreach (var item in listNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
