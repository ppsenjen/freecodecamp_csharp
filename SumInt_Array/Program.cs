namespace sum_of_int_array
{
    /*
     * create and initialize int arrays of numbers
     * create function sumofnumbers with return type 
     * int array param
     * function should total of all numbers
     * call in main output the total
     * extra:check array length
            *return -1 if array is empty
            *check return in main output message
            *do we need to return -1, how else can we make this
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            //created and initialized the array of numbers
            int[] numbers = new int[]
            {
            0,1,2,3,4,5

            };


            Console.WriteLine($"The total is: {SumOfNumbers(numbers)}");

            Console.ReadLine();
        }

        //created method for SumOfNumbers
        static int SumOfNumbers(int[] numbers)
        {
            int total = 0;

            foreach (int number in numbers)
            {
                total += number;
            }
            return total;

        }

    }
}
