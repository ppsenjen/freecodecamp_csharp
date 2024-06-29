using System;

public class Person
{
    // Fields
    private string firstName;
    private string lastName;

    // Properties
    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    // Constructor
    public Person(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }

    // Method
    public void DisplayFullName()
    {
        Console.WriteLine("Full Name: " + firstName + " " + lastName);
    }
}

class Program
{
    static void Main()
    {
        // Creating an object of the Person class
        Person person = new Person("John", "Doe");
        
        // Accessing properties
       Console.WriteLine("First Name: " + person.FirstName);
        Console.WriteLine("Last Name: " + person.LastName);

        // Calling a method
        person.DisplayFullName();
    }
}
