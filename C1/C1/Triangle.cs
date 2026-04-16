using System;

internal class Triangle
{
    private int a;
    private int b;
    private int c;

    public Triangle(int sideA, int sideB, int sideC)
    {
        A = sideA;
        B = sideB;
        C = sideC;
    }

    public Triangle(Triangle other)
    {
        a = other.a;
        b = other.b;
        c = other.c;
    }

    public int A
    {
        get { return a; }
        set { a = value > 0 ? value : 1; }
    }

    public int B
    {
        get { return b; }
        set { b = value > 0 ? value : 1; }
    }

    public int C
    {
        get { return c; }
        set { c = value > 0 ? value : 1; }
    }

    public int GetMinSide()
    {
        return Math.Min(a, Math.Min(b, c));
    }

    public override string ToString()
    {
        return "A = " + a + ", B = " + b + ", C = " + c;
    }
}