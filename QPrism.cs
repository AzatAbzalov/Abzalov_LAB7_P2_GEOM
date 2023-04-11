 class QPrism : TriPrism
 {
    protected Point2D c;
    public Point2D C { get; }
    public QPrism(Point2D m, Point2D a, Point2D b, Point2D c, double height) : base(m, a, b, height)
    {
        this.c = c;
    }
    public QPrism() : this(new Point2D(), new Point2D(0, 1), new Point2D(1, 1), new Point2D(1, 0), 1) { }

    public override void Input()
    {
        base.Input();
        Console.WriteLine("4 точка основания призмы");
        c.Input();
    }
    public override void Output()
    {
        Console.WriteLine("Прямая треугольная призма");
        Console.WriteLine("Координаты 1-ой точки основания: " + m.ToString());
        Console.WriteLine("Координаты 2-ой точки основания: " + a.ToString());
        Console.WriteLine("Координаты 3-ей точки основания: " + b.ToString());
        Console.WriteLine("Координаты 4-ой точки основания: " + c.ToString());
        Console.WriteLine("Длина боковой стороны: " + height);
    }
    public override double BaseS() 
    { 
        return QuadrAngleArea(m, a, b, c); 
    }
    public override double BaseP()
    {
        return m.Distance(a) + a.Distance(b) + b.Distance(c) + c.Distance(m);
    }
    public bool Parallelepiped()
    {
        if (m.Distance(a) == b.Distance(c) & a.Distance(b) == c.Distance(m))
            return true;
        return false;
    }
    public bool RightAngleParallelepiped()       
    {
        if (Parallelepiped() & m.Distance(b) == a.Distance(c))
            return true;
        return false;
    }
    public bool Cube()
    {
        if (RightAngleParallelepiped() & m.Distance(a) == a.Distance(b) & a.Distance(b) == height)
            return true;
        return false;
    }
    protected double QuadrAngleArea(Point2D k, Point2D l, Point2D m, Point2D n)
    {
        return 0.5 * ((k.X * l.Y + l.X * m.Y + m.X * n.Y + n.X * k.Y) - (k.Y * l.X + l.Y * m.X + m.Y * n.X + n.Y * k.X));
    }
}

