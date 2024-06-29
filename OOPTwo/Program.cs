using System;


//creating a public class called person
public class Person{

    //public properties
    public string FirstName { get; set;}
    public string LastName{ get; set;}

//A constructor to initialize the properties
public Person(string firstName, string lastName)
{
    FirstName = firstName;
    LastName = lastName;
}

/*a method to print the full names it can contain the virtual keyword which will
allow it to be overridden in the derived class
Key Points About override:
Inheritance: The override keyword is used in derived classes to modify the behavior of methods, properties, indexers, or events inherited from a base class.
Virtual or Abstract: The base class member that is being overridden must be marked with the virtual, abstract, or override keyword.
Same Signature: The overridden member must have the same signature as the member in the base class
*/
public virtual void DisplayFullName()
{
//Console.WriteLine($"Full name is: {FirstName} \n {LastName}");
Console.WriteLine("Full name " + FirstName + " " + LastName);
}
}
//inheritance
public class Student : Person
{
    //property 
public int StudentID { get; set; }

//constructor
public Student(string firstName, string lastName, int StudentID):base(firstName, lastName)
{
    StudentID = StudentID;
}

//DisplayFullName method is overridden using the override keyword
//it first calss the base class method (base.DisplayFullNmae
//to print the full name then it adds StudentID
public override void DisplayFullName()
{
    base.DisplayFullName();
    Console.WriteLine("Student ID" + StudentID);
}

}

class Program
{
    static void Main(string[] args)
    {
Student student = new Student("Mike","Ross" ,30200);
student.DisplayFullName();

    }
}