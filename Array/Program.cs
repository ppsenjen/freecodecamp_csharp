namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            //responsible for looping X number of times

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter a number: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());

            }


            // we can for loop to output the numbers mara moja
            // you can use for loop and go through a specified range ie from 3-5 
            //but chhosing a range is not supported in foreach loop 
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }

            Console.WriteLine();
            // we can also use for each loop for the eaxact same reason
            //when you want to go thru every single array 
            foreach (int num in numbers)
            {
                Console.WriteLine($"{num}");
            }
            /* Console.WriteLine("Enter a number: ");
            numbers[0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a number: ");
            numbers[1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a number");
            numbers[3]=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a number");
            numbers[4] = Convert.ToInt32(Console.ReadLine());
           */



        }
    }
}
