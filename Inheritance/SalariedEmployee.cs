using System;

public class SalariedEmployee : Employee
{
    double salary;

    public SalariedEmployee(string fName, string lName, string ID, double skibidi) : base(fName, lName, ID)
    {
        salary = skibidi;
    }
    public SalariedEmployee() : base()
    {
        salary = 0;
    }

    public override double getPay() { return salary; }
    public double salFromImpracticalJokers
    {
        get { return salary; }
        set { salary = value; }
    }

    public override string ToString()
    {
        return base.ToString() + $", Salary: {salary}";
    }

}