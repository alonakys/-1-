using System;
using System.Collections.Generic;
using System.Text;

namespace лаб1ооп
{
    class Rectangle
    {
        private double x1, y1, x2, y2, x3, y3, x4, y4;
        public Rectangle(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            if (!IsRectangle(x1, y1, x2, y2, x3, y3, x4, y4))
            {
                throw new ArgumentException("Невірні координати вершин прямокутника");
            }
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
            this.x4 = x4;
            this.y4 = y4;

        }
        private bool IsRectangle(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {

            //bool isRect = (x1 - x2) + (x3 - x4) + (y1 - y4) + (y2 - y3) == 0 || (x2 - x3) + (x1 - x4) + (y1 - y2) + (y3 - y4) == 0;
            double diag = Math.Sqrt(Math.Pow(x2 - x4, 2) + Math.Pow(y2 - y4, 2));
            double kat = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double kat2 = Math.Sqrt(Math.Pow(x1 - x4, 2) + Math.Pow(y1 - y4, 2));
            double kat3 = Math.Sqrt(Math.Pow(x3 - x4, 2) + Math.Pow(y3 - y4, 2));
            double kat4 = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
            bool isRect = (Math.Pow(kat, 2) + Math.Pow(kat2, 2) - Math.Pow(diag, 2)) <= 1e-5 && (Math.Pow(kat3, 2) + Math.Pow(kat4, 2) - Math.Pow(diag, 2) <= 1e-5);
            return isRect;
        }
        private double[] sides = new double[2];
        public double this[int index]
        {
            get { return sides[index]; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Значення сторони не може бути від'ємним.");
                sides[index] = value;
            }
        }
        public void InputSides()
        {
            this[0] = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            this[1] = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
        }
        public double CalcPer()
        {
            InputSides();
            return 2 * (this[0] + this[1]);
        }
        public double CalcArea()
        {
            return this[0] * this[1];
        }
    }
}

