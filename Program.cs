//Point2D c = new(4);
//c.Output();
//Point2D a = new();
//a.Output();
//a.Input();
//a.Output();
//Point2D b = new(-3, 5);
//b.Output();
//Console.WriteLine("Расстояние между точками a и b = " + a.Distance(b));

Point2D a1 = new(1, -1);
Point2D a2 = new(4);
Point2D a3 = new(-3, 5);
Point2D a4 = new(-1, -2);

//Cylinder c1 = new(a1, a2, 5);
//c1.Output();
//Console.WriteLine("Площадь окружности в основании цилиндра = " + c1.BaseS());
//Console.WriteLine("Длина окружности в основании = " + c1.BaseP());
//Console.WriteLine("Объем цилиндра =  " + c1.Volume());
//Console.WriteLine("Площадь боковой поверхности = " + c1.SideSurfaceS());
//Cylinder c2 = new(new Point2D(),a2, 3);
//c2.Output();
//Cylinder c3 = new();
//c3.Output();
//c3.Input();
//c3.Output();


//TriPrism t1 = new(a1, a2, a3, 5);
//t1.Output();
//Console.WriteLine("Площадь основания прямой треугольной призмы = " + t1.BaseS());
//Console.WriteLine("Периметр треугольника в основании = " + t1.BaseP());
//Console.WriteLine("Объем призмы =  " + t1.Volume());
//Console.WriteLine("Площадь боковой поверхности = " + t1.SideSurfaceS());
//TriPrism t2 = new(a1, a2, a3,1);
//t2.Output();
//TriPrism t3 = new(new Point2D(), new Point2D(0,1), new Point2D(1,0), 4);
//t3.Output();
//TriPrism t4 = new();
//t4.Output();
//t4.Input();
//t4.Output();

void Check(QPrism obj)
{
    if (obj.Parallelepiped())
        Console.WriteLine("параллелепипед");
    else Console.WriteLine("не параллелепипед");
    if (obj.RightAngleParallelepiped())
        Console.WriteLine("прямоугольный параллелепипед");
    else Console.WriteLine("не прямоугольный параллелепипед");
    if (obj.Cube())
        Console.WriteLine("куб");
    else Console.WriteLine("не куб");
}

a1 = new();
a2 = new(6, 1);
a3 = new(6, 7);
a4 = new(0, 6);
QPrism q1 = new(a1, a2, a3, a4, 6);
q1.Output();
Console.WriteLine("Площадь основания прямой четырехугольной призмы = " + q1.BaseS());
Console.WriteLine("Периметр четырехугольника в основании = " + q1.BaseP());
Console.WriteLine("Объем призмы =  " + q1.Volume());
Console.WriteLine("Площадь боковой поверхности = " + q1.SideSurfaceS());
Check(q1);
QPrism q2 = new(a1, a2, a3, a4, 1);
q2.Output();
QPrism q3 = new(new Point2D(),new Point2D(0,1),new Point2D(1,0),new Point2D(1,1), 1);
q3.Output();
QPrism q4 = new();
q4.Output();
Check(q4);
q4.Input();
q4.Output();
Check(q4);
