using System.Runtime.CompilerServices;

namespace BasicClassDeclaration
{
    public class Person
    {
        //fields
        private string firstname;
        private string lastname;


        //properties
        public string FirstName
        {
            get { return firstname; } 
            set {  firstname = value; } 
        }

        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }

        //constructor

        public Person(string firstName,string lastName)
        {
            this.firstname = firstName;
            this.lastname = lastName;
        }

        //method
        public void DisplayFullName()
        {
            Console.WriteLine($"Your full name is {FirstName} -{LastName}");
        }


        static void Main(string[] args)
        {
            //creating an object of the Person class
            Person person = new Person("Pam", "Chee");

            //Accessing properties
           // Console.WriteLine("");

            //calling a method
            person.DisplayFullName();


        }
}
}
