using System;
namespace Parse
{
    class MyClass1
    {

        static void Main(string[] args)
        {
            /* using int 
             
            string input = "123";
            int result;

            bool success = int.TryParse(input, out result);

            if(success )
            {
                Console.WriteLine($"Conversation successful: {result}");
            }
            else
                Console.WriteLine("Conversation failed");
            

            // using double 

            string input = "123.45";
            double result;

            bool success = double.TryParse(input, out result );

            if ( success ) // (double.TryParse(input, out double result))


            {
                Console.WriteLine($"Conversion successfull {result}");
            }

            else
            {
                Console.WriteLine("failed");

            }

            */


            while (true)
            {

                Console.WriteLine("Enter your age");
                string input = Console.ReadLine();


                if (int.TryParse(input, out int age))
                {
                    Console.WriteLine($"You entered a valid age:  {age}");
                }
                else
                {
                    Console.WriteLine("Invalid age please enter a valid age ");
                }

            }

        }




    }


}







