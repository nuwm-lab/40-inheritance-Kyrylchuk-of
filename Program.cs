using System;
class Program
{
    static void Main(string[] args)
    {
        Line line = new Line(1, -2, 3);
        line.Coefficients();
        line.CheckLine(1, 1);

        Hyperplane hyperplane = new Hyperplane(1, 2, 3, 4, 5);
        hyperplane.Coefficients();
        hyperplane.CheckHyperplane(1, 1, 1, 1);
    }
}
class Line
{
    private double a1;
    private double a2;
    private double a0;

    public double A1
    {
        get { return a1; }
        set { a1 = value; }
    }
    public double A2
    {
        get { return a2; }
        set { a2 = value; }
    }
    public double A0
    {
        get { return a0; }
        set { a0 = value; }
    }

    public Line(double a1, double a2, double a0)
    {
        A1 = a1;
        A2 = a2;
        A0 = a0;
    }

    public void Coefficients()
    {
        Console.WriteLine($"Рівняння прямої: {A1}x + {A2}y + {A0} = 0");
    }

    public void CheckLine(double x, double y)
    {
        if (A1 * x + A2 * y + A0 == 0)
        {
            Console.WriteLine($"Точка ({x}, {y}) належить прямій.");
        }
        else
        {
            Console.WriteLine($"Точка ({x}, {y}) не належить прямій.");
        }
    }
}

class Hyperplane : Line
{
    public double A3 { get; set; }
    public double A4 { get; set; }

    public Hyperplane(double a4, double a3, double a2, double a1, double a0)
        : base(a1, a2, a0)
    {
        A3 = a3;
        A4 = a4;
    }

    public new void Coefficients()
    {
        Console.WriteLine($"Рівняння гіперплощини: {A4}x4 + {A3}x3 + {A2}x2 + {A1}x1 + {A0} = 0");
    }

    public void CheckHyperplane(double x1, double x2, double x3, double x4)
    {
        if (A4 * x4 + A3 * x3 + A2 * x2 + A1 * x1 + A0 == 0)
        {
            Console.WriteLine($"Точка ({x1}, {x2}, {x3}, {x4}) належить гіперплощині.");
        }
    }
}

