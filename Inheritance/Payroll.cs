using System;

public class Payroll
{
    private List<Employee> employees = new List<Employee>();

    public void Add(Employee e)
    {
        employees.Add(e);
    }
    public void PrintChecks()
    {
        foreach (Employee e in employees)
        {
            Console.WriteLine(e.ToString());
            Console.WriteLine($"Pay : {e.getPay()}");
            Console.WriteLine("");
        }
    }
}