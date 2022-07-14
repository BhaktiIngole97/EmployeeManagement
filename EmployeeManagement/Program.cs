// See https://aka.ms/new-console-template for more information
//Constants
 const int IS_PART_TIME = 1;
 const int IS_FULL_TIME = 2;
 const int EMP_RATE_PER_HOUR = 20;
//Variables
 int empHrs = 0;
 int empWage = 0;
Random random = new Random();
//Computation
int empCheck = random.Next(0, 3);
switch (empCheck)
{
    case IS_PART_TIME:
        empHrs = 4;
        break;
    case IS_FULL_TIME:
        empHrs = 8;
        break;
    default:
        empHrs = 0;
        break;
}
empWage = empHrs * EMP_RATE_PER_HOUR;
Console.WriteLine("Emp Wage : " + empWage);



