using System.Drawing;

public class Point
{
    int x;
    int y;
    string color;

    public Point()
    {
        x = 0;
        y = 0;
        color = "black";
    }
    public Point(int xPoint, int yPoint, string myColor)
    {
        x = xPoint;
        y = yPoint;
        color = myColor;
    }

    public override string ToString()
    {
        return x + ", " + y + " " + color;

    }

    public void move(int moveX, int moveY)
    {
        this.x = this.x + moveX;
        this.y = this.y + moveY;
    }
    public bool isInQuadrant(int quad)
    {
        if (quad == 1 && x > 0 && y > 0)
        {
            return true;
        }
        else if (quad == 2 && x < 0 && y > 0)
        {
            return true;
        }
        else if (quad == 3 && x < 0 && y < 0)
        {
            return true;
        }
        else if (quad == 4 && x > 0 && y < 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string getColor()
    {
        return "The color is " + this.color;
    }

    public double distance(Point otherPoint)
    {
        return Math.Sqrt(Math.Pow(otherPoint.x - this.x, 2) + Math.Pow(otherPoint.y - this.y, 2));
    }






}