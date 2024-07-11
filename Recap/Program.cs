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
       
       //we can call it without the new keyword bcoz structs are value types
        WorkTask task;
        task.description = "Delicious pies were made";
        task.hours = 3;
        task.PerfomWorkTask();

//Array 
Console.WriteLine("How many employees Ids do you want to register? ");

int length = int.Parse(Console.ReadLine());
int[] employeeIds = new int[length];
for (int i = 0; i < length; i++)
{
    Console.WriteLine(" Enter the employee ID:");
    int id = int.Parse(Console.ReadLine());
    employeeIds[i] = id;
}

for (int i = 0; i < employeeIds.Length; i++)
{
  Console.WriteLine($"ID {i + 1} \t {employeeIds[i]}");

}