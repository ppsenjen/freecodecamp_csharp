using System.Diagnostics.Metrics;

namespace Arraymultiples
{
    internal class Program
    {
        /*
         * Define and initialize two intergers (num, length)
         * (7,5) -> [7, 14, 21, 28, 35]
         * Create int array with size length
         * loop thru and insert the ( loop counter x num) into the array
         * print the final array
         */
        static void Main(string[] args)
        {
            int num = 10;
            int length = 10;
            int counter = 0;

            int[] result = new int[length];

            for (int i = 1; i < result.Length; i++)
            {
                result[counter] = num * i;
                counter++;

            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item}");

            }

        }


    }
}
