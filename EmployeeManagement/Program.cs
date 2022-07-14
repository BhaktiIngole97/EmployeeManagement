using EmployeeManagement;
EmpWageBuilderobject dMart = new EmpWageBuilderobject("Dmart", 20, 2, 10);
EmpWageBuilderobject reliance = new EmpWageBuilderobject("Reliance", 10, 4, 20);
dMart.computeEmpWage();
Console.WriteLine(dMart.toString());
reliance.computeEmpWage();
Console.WriteLine(reliance.toString());


