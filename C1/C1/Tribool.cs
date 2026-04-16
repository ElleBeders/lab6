using System;

internal class Tribool : Triangle
{
    private bool isValid;
    private bool isRectangular;

    public Tribool(Triangle triangle) : base(triangle)
    {
        isValid = (A + B > C) && (A + C > B) && (B + C > A);

        if (isValid)
        {
            int a2 = A * A;
            int b2 = B * B;
            int c2 = C * C;
            isRectangular = (a2 + b2 == c2) || (a2 + c2 == b2) || (b2 + c2 == a2);
        }
        else
        {
            isRectangular = false;
        }
    }

    public bool IsValid
    {
        get { return isValid; }
    }

    public bool IsRectangular
    {
        get { return isRectangular; }
    }

    public void PrintField()
    {
        if (isValid)
        {
            Console.WriteLine("Это треугольник.");
        }
        else
        {
            Console.WriteLine("Это не треугольник.");
        }

        if (isRectangular)
        {
            Console.WriteLine("Это треугольник Пифагора.");
        }
        else if (isValid)
        {
            Console.WriteLine("Это не треугольник Пифагора.");
        }
    }

    public int Perimeter()
    {
        if (isValid)
        {
            return A + B + C;
        }
        else
        {
            return -1;
        }
    }
}