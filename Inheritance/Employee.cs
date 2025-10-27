using System;

public abstract class Employee
{
    string firstName;
    string lastName;
    string employeeNum;

    private int ptoDaysTaken;
    public const int MAX_PTO_DAYS = 30;

    public Employee(string fName, string lName, string ID)
    {
        firstName = fName;
        lastName = lName;
        employeeNum = ID;
        ptoDaysTaken = 0;
    }

    public Employee()
    {
        firstName = "";
        lastName = "";
        employeeNum = "";
        ptoDaysTaken = 0;
    }

    public string nameF
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string nameL
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public string IDNumber
    {
        get { return employeeNum; }
        set { employeeNum = value; }
    }

    public int PtoDaysTaken
    {
        get { return ptoDaysTaken; }
        set
        {
            if (value <= MAX_PTO_DAYS)
            {
                ptoDaysTaken = value;
            }
            else
            {
                throw new ArgumentException($"PTO days taken ({value}) exceeds the maximum allowed ({MAX_PTO_DAYS}).");
            }
        }
    }

    public static int GetMaxPtoDays()
    {
        return MAX_PTO_DAYS;
    }

    public abstract double getPay();

    public override string ToString()
    {
        return $"Name: {firstName} {lastName}, Employee #: {employeeNum}, PTO Taken: {ptoDaysTaken}/{MAX_PTO_DAYS}";
    }
}
