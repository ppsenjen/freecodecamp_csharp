namespace AreaTriangle
{
    /*
     * Ask the user for width and height,store them
     * create function to calculate the area
     * function should cal area using (width*height)/2
     * call in main and print out the area of the triangle*/

    internal class Program
    {
        static void Main(string[] args)
        {
            //instead of doing this
            /* Console.WriteLine("Enter width: ");
             int width = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Enter height: ");
             int height = Convert.ToInt32(Console.ReadLine()); */

            //do this 

            int width = ReadInt("Enter width: ");
            int height = ReadInt("Enter height:");

            //calling the calcarea method

            int result = CalcArea(width, height);

            Console.WriteLine($"The area is {result}");


            Console.ReadLine();
        }
        //method to read the values entered
        static int ReadInt(string message)

        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());

        }
        //method to do the calculations
        static int CalcArea(int width, int height)
        {
            return (width * height) / 2;
        }

    }
}
