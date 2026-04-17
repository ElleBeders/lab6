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
        set 
        { 
            if (value > 0)
            {
                a = value;
            }
            else
            {
                a = 1;
            }
        }
    }

    public int B
    {
        get { return b; }
        set
        {
            if (value > 0)
            {
                b = value;
            }
            else
            {
                b = 1;
            }
        }
    }

    public int C
    {
        get { return c; }
        set
        {
            if (value > 0)
            {
                c = value;
            }
            else
            {
                c = 1;
            }
        }
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
