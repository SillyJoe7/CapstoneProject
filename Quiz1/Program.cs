namespace Quiz1;

class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point(10, 20, "blue");
        Point p2 = new Point();
        Console.WriteLine(p1.ToString());
        Console.WriteLine(p2.ToString());
        p1.move(5, 10);
        Console.WriteLine(p1.ToString());


        if (p1.isInQuadrant(2))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
        double dist = p1.distance(p2);
        Console.WriteLine(dist);
        Console.WriteLine(p1.getColor());


        Point[] points = new Point[4];
        points[0] = p1;
        points[3] = p2;
        for (int i = 0; i < points.Length; i++)
        {
            if (points[i] != null)
            {
                Console.WriteLine(points[i]);
            }
        }
    }
}
