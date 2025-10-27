using System;

public class Student
{
    string name;
    public string nam
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    private List<int> scores;
    private string major;
    public Student(string N, string M)
    {
        name = N;

        major = M;
        scores = new List<int>();

    }

    public Student()
    {
        name = "";
        major = "";
        scores = new List<int>();
    }

    public void recordTest(int score)
    {
        scores.Add(score);
    }
    public virtual string getDegree()
    {
        return major; 
    }
    public double avg
    {
        get
        {
            if (scores == null)
                return 0;
            return scores.Average();
        }



    }
        public override string ToString()
    {
        return "Name: " + name +", Degree: " + major + " Average grade: " + avg;
    }
     

}
