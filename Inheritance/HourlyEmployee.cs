public class HourlyEmployee : Employee
{
    private double hourlyRate;
    private int hoursPerWeek;

    public HourlyEmployee(string fName, string lName, string ID, double hrrate, int hrPerWeek)
        : base(fName, lName, ID)
    {
        hourlyRate = hrrate;
        hoursPerWeek = hrPerWeek;
    }

    public HourlyEmployee() { }

    public double HourlyRate
    {
        get { return hourlyRate; }
        set { hourlyRate = value; }
    }

    public int HoursPerWeek
    {
        get { return hoursPerWeek; }
        set { hoursPerWeek = value; }
    }

    public override double getPay()
    {
        return hourlyRate * hoursPerWeek;
    }

    public override string ToString()
    {
        return base.ToString() + $", Hourly Rate: {hourlyRate}, Hours per week: {hoursPerWeek}, Weekly Pay: {getPay()}";
    }
}
