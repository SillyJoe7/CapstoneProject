public class Gradstudent : Student
{
    private string resaserchArea;
    public Gradstudent() : base()
    {
        resaserchArea = "undecided";
    }

    public Gradstudent(string name, string resaserchArea) : base(name, "MS")
    {
        this.resaserchArea = resaserchArea;
    }

    public override string getDegree()
    {
        return base.getDegree() + "research area " + resaserchArea;
    }
}