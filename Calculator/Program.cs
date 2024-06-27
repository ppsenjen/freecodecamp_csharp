using System.Runtime.InteropServices;

namespace calculator
{
    //trying out a basic calculator using methods with parametres
    internal class Program
    {
        static void Main(string[] args)
        {
            int firsnum = ReadInt("Enter first number");
            int secondnum = ReadInt("Enter second number");
            int result = Add(firsnum, secondnum);
        }

        static int ReadInt(string message)
        {
            Console.WriteLine($"{message}");
            return Convert.ToInt32(Console.ReadLine());

        }

        static int Add(int a, int b)
        {
            return a + b;
        }
    }

}
