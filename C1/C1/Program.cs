using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Создание треугольника: ");
        Triangle tri1 = new Triangle(6, 8, 10);
        Triangle tri2 = Create();
        Console.WriteLine();
        Print(tri1, 1);
        Print(tri2, 2);
        Console.WriteLine();

        int min1 = tri1.GetMinSide();
        Console.WriteLine("Малая сторона треугольника 1 = " + min1);
        int min2 = tri2.GetMinSide();
        Console.WriteLine("Малая сторона треугольника 2 = " + min2);
        Console.WriteLine();

        Tribool tr1 = new Tribool(tri1);
        Tribool tr2 = new Tribool(tri2);
        Analyze(tr1, 1);
        Analyze(tr2, 2);
    }

    public static void Print(Triangle triangle, int number)
    {
        Console.WriteLine("Треугольник " + number + " : " + triangle.ToString());
    }

    public static Triangle Create()
    {
        int a, b, c;
        Console.Write("A = ");
        a = int.Parse(Console.ReadLine());
        Console.Write("B = ");
        b = int.Parse(Console.ReadLine());
        Console.Write("C = ");
        c = int.Parse(Console.ReadLine());
        Triangle tri = new Triangle(a, b, c);
        return tri;
    }

    public static void Analyze(Tribool tribool, int number)
    {
        Console.WriteLine("Анализ треугольника " + number + ":");
        tribool.PrintField();
        int perimeter = tribool.Perimeter();
        if (perimeter != -1)
        {
            Console.WriteLine("Периметр = " + perimeter + ".");
        }
        Console.WriteLine();
    }
}
