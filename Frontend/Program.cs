﻿using Backend;

try
{
    //var date1 = new Date();
    //var date2 = new Date(2028, 2, 29);
    //var date3 = new Date(2026, 12, 3);
    //Console.WriteLine(date1);
    //Console.WriteLine(date2);
    //Console.WriteLine(date3);

    var employee1 = new SalaryEmployee(1010, "Marta", "Lopez", new Date(1976, 1, 13), new Date(2020, 11, 20), true, 2100000);
    var employee2 = new CommissionEmployee(2020, "Sandra", "Cardona", new Date(2000, 12, 3), new Date(2020, 11, 30), true, 0.03f, 800000000);
    var employee3 = new CommissionEmployee(3030, "Hector", "Pulido", new Date(1991, 03, 22), new Date(2017, 10, 03), true, 0.03f, 26000000);

    var employees = new List<Employee> { employee1, employee2, employee3 };
    foreach (var employee in employees)
    {
        Console.WriteLine(employee);
        Console.WriteLine("---------------------------------------------");
    }

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}