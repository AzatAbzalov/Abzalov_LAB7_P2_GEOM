 class Cylinder : Point2D
 {
    protected Point2D a, m;
    protected double height;
    public Point2D A { get; } public Point2D M { get; }
    public double Height { get; }
    public Cylinder(Point2D a, Point2D m, double height)
    {
        this.a = a;
        this.m = m;
        this.height = height;
    }
    public Cylinder() : this(new Point2D(), new Point2D(1, 1), 1) { }
    public override void Input()
    {
        Console.WriteLine("Центр окружности в основании цилиндра.");
        m.Input();
        Console.WriteLine("Точка окружности в основании.");
        a.Input();
        Console.Write("Введите высоту: ");
        height = double.Parse(Console.ReadLine());
    }
    public override void Output()
    {
        Console.WriteLine("Цилиндр");
        Console.WriteLine("К-та центра окружности в основании: " + m.ToString());
        Console.WriteLine("К-та точки окружности в основании: " + a.ToString());
        Console.WriteLine("Высота: " + height);
    }
    protected double R() 
    {
        return m.Distance(a);
    }
    public virtual double BaseS()
    {
        return Math.PI * R() * R();
    }
    public virtual double BaseP()
    {
        return 2 * Math.PI * R();
    }
    public double Volume()
    {
        return BaseS() * height;
    }
    public double SideSurfaceS()
    {
        return BaseP() * height;
    }
}
