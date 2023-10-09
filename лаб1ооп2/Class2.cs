using System;
using System.Collections.Generic;
using System.Text;

namespace лаб1ооп2
{
    class TRPiramid : TRTriangle
    {
        protected double height;
        public TRPiramid()
        {
            height = 2;
        }
        public TRPiramid(double a, double b, double h) : base(a, b)
        {
            if (h > 0)
            {
                height = h;
            }
            else
            {
                throw new ArgumentException("Введено некоректно висоту");
            }
        }
        public TRPiramid(TRPiramid other) : base(other)
        {
            height = other.height;
        }
        public double Height
        {
            get { return height; }
            set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    throw new ArgumentException("Висота пiрамiди повинна бути додатнiм числом");
                }
            }
        }
        public double CalcVolum()
        {
            return (1.0 / 3.0 * base.CalcArea() * height);
        }
        public override string ToString()
        {
            return $"Прямокутна трикутна пiрамiда зi сторонами {SideA}, {SideB} та висотою {height} має об'єм {CalcVolum()}";
        }
        public static bool operator ==(TRPiramid p1, TRPiramid p2)
        {
            return p1.SideA == p2.SideA && p1.SideB == p2.SideB && p1.height == p2.height;
        }
        public static bool operator !=(TRPiramid p1, TRPiramid p2)
        {
            return !(p1 == p2);
        }
        public static TRPiramid operator *(double multiplier, TRPiramid pyramid)
        {
            return new TRPiramid(multiplier * pyramid.SideA, multiplier * pyramid.SideB, multiplier * pyramid.height);
        }

        public static TRPiramid operator *(TRPiramid pyramid, double multiplier)
        {
            return new TRPiramid(multiplier * pyramid.SideA, multiplier * pyramid.SideB, multiplier * pyramid.height);
        }
    }
}
