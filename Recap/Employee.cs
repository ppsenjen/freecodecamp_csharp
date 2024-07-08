using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name
{
   class Employee
   {
    public string firstName;
    public string lastName;
    public string email;

    public int numberOfHoursWorked;
    public double wage;
    public double hourlyRate;

    public DateTime birthday;
    const int minimalHoursWorkedUnit = 1;

    //another constuctor calling the previous one
 public Employee(string first,string last, string em,DateTime bd) : this(first,last,em,bd,0)
 {

 }




// constructor
public Employee(string first,string last, string em,DateTime bd, double rate)
{
firstName = first;
lastName = last;
email = em;
birthday = bd;
hourlyRate = rate;
}
    public void PerformWork()
    {
PerformWork(minimalHoursWorkedUnit);

    }

//method overloading
public void PerformWork(int numberOfHours)
{

numberOfHoursWorked += numberOfHours;
Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHours} hours");

}

public double ReceiveWage(bool resetHours = true)
{
wage = numberOfHoursWorked * hourlyRate;

Console.WriteLine($"{firstName} {lastName} has received a wage of {wage} for {numberOfHoursWorked} hours of work. ");
if(resetHours)

    numberOfHoursWorked = 0;
    return wage;
}



public void DisplayEmployeeDetails()
{

Console.WriteLine($"\nFirst name: \t{firstName}\nLast Name\t{lastName}\nEmail:\t\t{email}\nBirthday:\t{birthday.ToShortTimeString()}\n");

}

   } 
}
