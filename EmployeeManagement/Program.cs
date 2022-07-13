// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to EmployeeManagement App");
int IS_FULL_TIME = 1;
Random random = new Random();
int empCheck = random.Next(0, 2);
if (empCheck == IS_FULL_TIME)
{
    Console.WriteLine("Employee is present");
}
else
{

    Console.WriteLine("Employee is absent");

}



