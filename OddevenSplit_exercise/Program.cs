namespace oddevensplitexercise
{
    /*
     * creat two lists with interger data types
     * one for even numbers and one for odd numbers
     * loop from 0-20
            *  if number is even,add to even list
            *  if number is odd add to odd list
      *  print even list
      *  print odd list
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            //lists have count while arrays have length
            List<int> odd = new List<int>();
            List<int> even = new List<int>();

            //checking foe the ood / even numbers
            for (int i = 0; i <= 20; i++)
            {

                if (i % 2 == 0)
                {
                    even.Add(i);
                }
                else
                {

                    odd.Add(i);
                }
            }

            //displaying on the screen using foreach
            Console.WriteLine("Printing the even numbers");

            foreach (var item in even)
            {
                Console.Write($"{item}");

            }

            Console.WriteLine(Environment.NewLine + "Printing odd numbers");

            foreach (var item in odd)
            {
                Console.Write($"{item}");
            }

            Console.ReadLine();
        }
    }
}
