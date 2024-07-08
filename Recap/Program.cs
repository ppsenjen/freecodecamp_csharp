using Name;

Console.WriteLine("Creating an employee");
Console.WriteLine("***********");
Employee Pam = new Employee ("pam","psenjen","ppsenjen@fameve.com",new DateTime(2000,03,10),25);

Pam.DisplayEmployeeDetails();
Pam.PerformWork();
Pam.PerformWork(5);

double ReceiveWagePam = Pam.ReceiveWage(true);
Console.WriteLine($"Wage paid(message from Program): {ReceiveWagePam}");