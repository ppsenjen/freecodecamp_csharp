using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name
{
   class Employee
   {
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string email { get; set; }

    public int numberOfHoursWorked { get; set; }
    public double wage { get; set; }
    public double hourlyRate { get; set; }

    public DateTime birthday    { get; set; }
    public EmployeeType employeeType{ get; set; }
    const int minimalHoursWorkedUnit = 1;

    //another constuctor calling the previous one
 public Employee(string first,string last, string em,DateTime bd) : this(first,last,em,bd,0,EmployeeType.StoreManger)
 {

 }




// constructor
public Employee(string first,string last, string em,DateTime bd, double rate,EmployeeType empType)
{
firstName = first;
lastName = last;
email = em;
birthday = bd;
hourlyRate = rate;
employeeType = empType;
}
    public void PerformWork()
    {
PerformWork(minimalHoursWorkedUnit);

    }

public int CalculateBonus(int bonus)
{

if (numberOfHoursWorked  < 10)
bonus *= 2;
Console.WriteLine("The employee got a bonus of " + bonus);
return bonus;
}


//method overloading
public void PerformWork(int numberOfHours)
{

numberOfHoursWorked += numberOfHours;
Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHours} hours");

}

public double ReceiveWage()
{
    if (employeeType == EmployeeType.StoreManger)
    {
        Console.WriteLine($"An extra wage was added since {firstName} is a manager!");
    
wage = numberOfHoursWorked * hourlyRate * 1.25;
    } 
    else {
        wage = numberOfHoursWorked * hourlyRate;
    }
    
Console.WriteLine($"{firstName} {lastName} has received a wage of {wage} for {numberOfHoursWorked} hours of work. ");
//if(resetHours)

   // numberOfHoursWorked = 0;
    return wage;
}



public void DisplayEmployeeDetails()
{

Console.WriteLine($"\nFirst name: \t{firstName}\nLast Name\t{lastName}\nEmail:\t\t{email}\nBirthday:\t{birthday.ToShortTimeString()}\n");

}

   } 
}
