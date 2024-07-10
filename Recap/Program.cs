using Name;
using System.Text;
Console.WriteLine("Creating an employee");
Console.WriteLine("***********");
Employee Pam = new Employee ("pam","psenjen","ppsenjen@fameve.com",new DateTime(2000,03,10),25,EmployeeType.StoreManger);
Employee Che = new Employee ("pam","Sally","ppsenjen@fameve.com",new DateTime(2000,03,10),25,EmployeeType.Research);

Pam.DisplayEmployeeDetails();
//Pam.PerformWork();
Pam.PerformWork(10);

Pam.ReceiveWage();
Che.PerformWork(10);
Che.ReceiveWage();
//Pam.ReceiveWage();
//calling value types
//Pam.CalculateBonus(15);


string firstName = "pm";
string lastName = "psenjen";
//using string builder
StringBuilder sb = new StringBuilder();

    sb.Append("Last Name");
    sb.AppendLine(lastName);  
    sb.Append("First name");
    sb.AppendLine(firstName);

    string result = sb.ToString();
       
