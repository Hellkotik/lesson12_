using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace les12
{
    public static class Circle
    {
        const double x0 = 0;
        const double y0 = 1;

        static public double GetLenght(double r)
        { return Math.PI * r; }

        static public double GetSquare(double r)
        { return Math.PI * r * r; }

        static public bool GetPrin(double x1, double y1, double r)
        {
            return ((x1 - x0) * (x1 - x0)) + ((y1 - y0) * (y1 - y0)) <= r * r;

        }

    }
}