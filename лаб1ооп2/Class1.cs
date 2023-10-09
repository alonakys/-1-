using System;
using System.Collections.Generic;
using System.Text;

namespace лаб1ооп2
{
    class TRTriangle
    {
        protected double sideA;
        protected double sideB;
        public TRTriangle()
        {
            sideA = 6;
            sideB = 8;
        }
        public TRTriangle(double a, double b)
        {
            if (a > 0 && b > 0)
            {
                sideA = a;
                sideB = b;
            }
            else
            {
                throw new ArgumentException("Введено некоректнi сторони");
            }
        }
        public TRTriangle(TRTriangle other)
        {
            sideA = other.sideA;
            sideB = other.sideB;
        }
        public double SideA
        {
            get { return sideA; }
            set
            {
                if (value > 0)
                {
                    sideA = value;
                }
                else
                {
                    throw new ArgumentException("Сторона трикутника повинна бути додатним числом.");
                }
            }
        }
        public double SideB
        {
            get { return sideB; }
            set
            {
                if (value > 0)
                {
                    sideB = value;
                }
                else
                {
                    throw new ArgumentException("Сторона трикутника повинна бути додатним числом.");
                }
            }
        }
        public double CalcArea()
        {
            return 0.5 * sideA * sideB;
        }
        public double CalcPer()
        {
            return sideA + sideB + Math.Sqrt(sideA * sideA + sideB * sideB);
        }
        public override string ToString()
        {
            return $"Прямокутний трикутник iз катетами {sideA} та {sideB} має периметр {CalcPer()} та площу {CalcArea()}";
        }
        public static TRTriangle operator *(double multi, TRTriangle triangle)
        {
            return new TRTriangle(multi * triangle.sideA, multi * triangle.sideB);
        }
        public static TRTriangle operator *(TRTriangle triangle, double multi)
        {
            return new TRTriangle(multi * triangle.sideA, multi * triangle.sideB);
        }
        public static bool operator ==(TRTriangle tr1, TRTriangle tr2)
        {
            return ((tr1.sideA == tr2.sideA && tr1.sideB == tr2.sideB) || (tr1.SideA == tr2.sideB && tr1.sideB == tr2.SideA));
        }
        public static bool operator !=(TRTriangle t1, TRTriangle t2)
        {
            return !(t1 == t2);
        }
    }
}
