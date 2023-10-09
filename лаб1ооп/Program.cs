using System;

namespace лаб1ооп
{
    class Program
    {
        static double[] Input()
        {
            double[] values = new double[8];
            int k = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Введiть координати точки");
                double[] value = Array.ConvertAll(Console.ReadLine().Trim().Split(), Convert.ToDouble);
                values[k] = value[0];
                values[k + 1] = value[1];
                k += 2;
            }
            return values;
        }
        static void Main(string[] args)
        {
            double[] values = Input();
            Rectangle rect = new Rectangle(values[0], values[1], values[2], values[3], values[4], values[5], values[6], values[7]);
            Console.WriteLine("Периметр: " + rect.CalcPer());
            Console.WriteLine("Площа: " + rect.CalcArea());
        }
    }
}
