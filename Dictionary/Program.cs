using System;
using System.Collections.Generic;

namespace dictionary
{

    internal class Program
    {
        //Like making an account on a website and you get a unique key 
        //All keys must be unique but values can be similar 
        static void Main(string[] args)
        {
            /*  Dictionary<int, string> names = new Dictionary<int, string>
              {
                  {1, "pam"},
                  {3,"Odhis" },
                  {4,"Kudos" }

              };

              //using forloop to display the results
              /*
               * for (int i = 0; i < names.Count; i++)
              {
                 KeyValuePair<int, string> pair = names.ElementAt(i);
                  Console.WriteLine($"{pair.Key} - {pair.Value}");
              }

              Console.WriteLine();

              //using foreach to display the results looks easier than for loop

              foreach (KeyValuePair<int, string>item in names)
              {
                  Console.WriteLine($"{item.Key} - {item.Value}");
              }
              */

            Dictionary<string, string> teacher = new Dictionary<string, string>
            {
                {"Math" , "Pam"},
                {"English", "Paige" }

            };
            //when you enter a wrong name it will trhow an exception error 
            //so its advised to check first if it exists before running it 
            //Console.WriteLine(teacher["math"]); error u need to try parse

            if (teacher.TryGetValue("Math", out string teachers))
            {
                Console.WriteLine(teachers);
            }
            else
            {
                Console.WriteLine("Math teacher not found");
            }
            //teacher.Remove("Math");

            if (teacher.ContainsKey("Math"))
            {
                teacher.Remove("Math");

            }
            else
            {
                Console.WriteLine("Math not found");
            }

            foreach (var item in teacher)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
