using Abzalov_LAB7_P2_GEOM;
class Point2D : ICLIable
{
    public double X { get; set; }
    public double Y { get; set; }
    public Point2D() : this(0, 0) { }
    public Point2D(double x) : this(x,x) { }
    public Point2D(double X, double Y)
    {
        this.X = X;
        this.Y = Y;
    }
    public double Distance(Point2D a) { return Math.Sqrt(X * X + Y * Y); }
    public override string ToString()
    {
        return $"({X}, {Y})";
    }
    public virtual void Input()
    {
        Console.Write("Введите коор-ты: ");
        Console.Write("x = ");
        X = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        Y = double.Parse(Console.ReadLine());
    }
    public virtual void Output()
    {
        Console.WriteLine("Точка " + ToString());
    }
}