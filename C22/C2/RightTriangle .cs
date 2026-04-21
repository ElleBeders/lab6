using System;

internal class RightTriangle
{
    private double _a; 
    private double _b; 

    public RightTriangle(double sideA, double sideB)
    {
        A = sideA;
        B = sideB;
    }

    public RightTriangle(RightTriangle other)
    {
        _a = other._a;
        _b = other._b;
    }

    public double A
    {
        get 
        { 
            return _a; 
        }
        set
        {
            if (value > 0)
            {
                _a = value;
            }
            else
            {
                _a = 1;
            }
        }
    }

    public double B
    {
        get 
        { 
            return _b; 
        }
        set
        {
            if (value > 0)
            {
                _b = value;
            }
            else
            {
                _b = 1;
            }
        }
    }

    public double GetArea()
    {
        return (_a * _b) / 2;
    }

    public static implicit operator bool(RightTriangle Tr)
    {
        return Tr._a > 0 && Tr._b > 0;
    }

    public static explicit operator double(RightTriangle Tr)
    {
        if (Tr)
        {
            return Tr.GetArea();
        }
        else 
        {
            return -1;
        }
    }

    public static RightTriangle operator ++(RightTriangle Tr)
    {
        return new RightTriangle(Tr._a * 2, Tr._b * 2);
    }

    public static RightTriangle operator --(RightTriangle Tr)
    {
        return new RightTriangle(Tr._a / 2, Tr._b / 2);
    }

    public static bool operator <=(RightTriangle Tr1, RightTriangle Tr2)
    {
        return Tr1.GetArea() <= Tr2.GetArea();
    }

    public static bool operator >=(RightTriangle Tr1, RightTriangle Tr2)
    {
        return Tr1.GetArea() >= Tr2.GetArea();
    }

    public override string ToString()
    {
        return "(" + _a + ", " + _b + ")";
    }
}