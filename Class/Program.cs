namespace Class
{
    internal class Program
    {
        //difference between a structure and a class 
        /*
         * A structure is limited to one constructor since all of the fields
         * needs to be assyned once the struct is created
         * A structure you have to declare all the variables inside the parametre and assign them all inside the constructor
         * 
         * A class can have many constructors even an empty contrutor is accepted
         * All functions should be within the class
         */

        class Person 
        {
            public string name;
            public int age;

            public Person() 
            { 
            }

            public Person (string name)
            {
                this.name = name;
                this.age = 0;
            }

            public Person (int age)
            {
                this.age = age;
                this.name = "";
            }

            public Person (string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Person person = new Person(name, age);

            Console.WriteLine(person.name);
            Console.WriteLine(person.age);


            Console.ReadLine();

        }
    }
}
