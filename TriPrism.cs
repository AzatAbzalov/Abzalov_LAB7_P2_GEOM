class TriPrism : Cylinder
{
    protected Point2D b; public Point2D B { get; }
    public TriPrism(Point2D m, Point2D a, Point2D b, double height) : base(m, a, height)
    {
        this.b = b;
    }
    public TriPrism() : this(new Point2D(), new Point2D(0, 1), new Point2D(1, 0), 1) { }
    public override void Input()
    {
        Console.WriteLine("1 точка основания призмы");
        m.Input();
        Console.WriteLine("2 точка основания призмы");
        a.Input();
        Console.WriteLine("3 точка основания призмы");
        b.Input();
        Console.Write("Введите длину боковой стороны: ");
        height = double.Parse(Console.ReadLine());
    }
    public override void Output()
    {
        Console.WriteLine("Прямая треугольная призма");
        Console.WriteLine("К-ты 1-ой точки основания: " + m.ToString());
        Console.WriteLine("К-ты 2-ой точки основания: " + a.ToString());
        Console.WriteLine("К-ты 3-ей точки основания: " + b.ToString());
        Console.WriteLine("Длина боковой стороны: " + height);
    }
    public override double BaseS()
    {
        return TriS(m, a, b);
    }
    public override double BaseP()
    {
        return Math.Round(m.Distance(a) + a.Distance(b) + b.Distance(m), 3);
    }
    protected double TriS(Point2D i, Point2D k, Point2D j)
    {
        double a1, a2, a3, p;
        a1 = i.Distance(k);
        a2 = k.Distance(j);
        a3 = j.Distance(i);
        p = (a1 + a2 + a3) / 2;
        return Math.Sqrt(p * (p - a1) * (p - a2) * (p - a3));
    }
}
