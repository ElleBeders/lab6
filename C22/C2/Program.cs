using System;

internal class Program
{

    private static void Main(string[] args)
    {
        Console.WriteLine("Создание треугольника 1: ");
        RightTriangle tri1 = Create();
        Print(tri1, 1);
        Console.WriteLine();
        Console.WriteLine("Создание треугольника 2: ");
        RightTriangle tri2 = Create();
        Print(tri2, 2);
        Console.WriteLine();

        Console.WriteLine("Уменьшаем треугольник 1: ");
        Print(--tri1, 1);
        Console.WriteLine();
        Console.WriteLine("Увеличиваем треугольник 2: ");
        Print(++tri2, 2);
        Console.WriteLine();

        double s_tr1 = (double)tri1;
        double s_tr2 = (double)tri2;
        Console.WriteLine("Площадь треугольника 1: " + s_tr1);
        Console.WriteLine("Площадь треугольника 2: " + s_tr2);
        Console.WriteLine();

        Srav(tri1, tri2);

    }

    public static void Srav(RightTriangle tr1, RightTriangle tr2)
    {
        Console.WriteLine("Сравнение треугольников:");
        bool b_tr_1 = (tr1 <= tr2);
        bool b_tr_2 = (tr1 >= tr2);
        if ((b_tr_1 == b_tr_2)&&((double)tr1 == (double)tr2))
        {
            Console.WriteLine("Треугольники равны.");
        }
        else
        {
            Console.WriteLine("Треугольники не равны.");
            if (b_tr_1)
            {
                Console.WriteLine("Треугольник 2 больше.");
            }
            else 
            {
                Console.WriteLine("Треугольник 1 больше.");
            }
        }
    }

    public static void Print(RightTriangle tr, int number)
    {
        Console.WriteLine("Треугольник " + number + " : " + tr.ToString());
    }

    public static RightTriangle Create()
    {
        Console.Write("Катет 1 = ");
        double a = Check();
        Console.Write("Катет 2 = ");
        double b = Check();
        RightTriangle tri = new RightTriangle(a, b);
        if (tri)
        {
            Console.WriteLine("Треугольник существует.");
        }
        else
        {
            Console.WriteLine("Треугольник не существует.");
        }
        return tri;
    }

    public static double Check()
    {
        double a = 1;
        int i = 0;
        int k = 0;
        while (i == 0)
        {
            if (k != 0)
            {
                Console.Write("Неверный ввод, повторите попытку: ");
            }
            string input = Console.ReadLine();
            if (double.TryParse(input, out a) == true)
            {
                i = 1;
            }
            k++;
            if (k == 5)
            {
                a = 1;
                i = 1;
            }
        }
        return a;
    }
}