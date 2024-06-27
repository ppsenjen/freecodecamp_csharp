using System.Security.Principal;

namespace parameters_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  //normal way
              Console.WriteLine("Enter the principle amount: ");
              double principle = Convert.ToDouble(Console.ReadLine());

              Console.WriteLine("Enter the annual interest rate (in %): ");
              double rate = Convert.ToDouble(Console.ReadLine());

              Console.WriteLine("Enter the time in years: ");
              int time = Convert.ToInt32(Console.ReadLine());
            */

            //prompting the user to enter values using separate functions
            double principle = GetDoubleInput("Enter the principle amout");
            double rate = GetDoubleInput("Enter the annual interest");
            int time = GetIntInput("Enter the time in years");


            //calculate interest
            double interest = CalculateInterest(principle, rate, time);


            //output
            Console.WriteLine($"The interest for a principal amount of ${principle} at an annual interest rate of {rate}% for {time} years is ${interest}");
            Console.ReadLine();

        }
        //function to calculate interest
        static double CalculateInterest(double principle, double rate, int time)
        {
            double interest = (principle * rate * time) / 100;
            return interest;
        }

        //function to prompt user for a double input
        static double GetDoubleInput(string input)
        {
            Console.WriteLine(input);
            return Convert.ToDouble(Console.ReadLine());
        }

        static int GetIntInput(string input)
        {
            Console.WriteLine(input);
            return Convert.ToInt32(Console.ReadLine());
        }

    }
}
