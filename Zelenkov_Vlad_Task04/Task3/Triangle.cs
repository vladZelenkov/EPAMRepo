using System;

namespace Task3
{
    public class Triangle
    {
        public int A { get; private set; }
        public int B { get; private set; }
        public int C { get; private set; }

        public Triangle(int parA, int parB, int parC)
        {
            bool b1 = parA + parB > parC;
            bool b2 = parB + parC > parA;
            bool b3 = parA + parC > parB;
            bool b4 = parA > 0 && parB > 0 && parC > 0;
            if (b1 && b2 && b3 && b4)
            {
                A = parA;
                B = parB;
                C = parC;
            }
            else
            {
                throw new Exception("there is no such triangle");
            }
        }

        public double GetPerimeter()
        {
            return A + B + C;
        }

        public double GetArea()
        {
            double p = GetPerimeter() / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
