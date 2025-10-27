using System.ComponentModel.Design;

namespace Quiz2;

class Program
{
    
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();
        Student s1 = new Student("Bill", "English");
        s1.recordTest(0);
        students.Add(s1);
        Student s2 = new Student("Sue", "CS");
        s2.recordTest(75);
        s2.recordTest(85);
        students.Add(s2);
        Gradstudent s3 = new Gradstudent("betty", "CS");
        s3.recordTest(0);
        students.Add(s3);

        foreach (Student s in students)
        {
            Console.WriteLine(s);

        }


    }
}
