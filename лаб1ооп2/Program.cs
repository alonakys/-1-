using System;

namespace лаб1ооп2
{
    class Program
    {
        static void Main(string[] args)
        {
            TRTriangle tr = new TRTriangle();
            Console.WriteLine("Введiть довжини двох катетiв через Enter");
            double firstk = Convert.ToDouble(Console.ReadLine());
            double secondk = Convert.ToDouble(Console.ReadLine());
            TRTriangle tr2 = new TRTriangle(firstk, secondk);
            TRTriangle trc = new TRTriangle(tr2);
            TRTriangle trm = 2 * tr2;
            Console.WriteLine($"Трикутник за замовчуванням: " + tr);
            Console.WriteLine($"Введений користувачем: " + tr2);
            Console.WriteLine($"Копiя введеного користувачем: " + trc);
            Console.WriteLine($"Введений користувачем та помножений на число: " + trm);
            if (tr == trm)
            {
                Console.WriteLine("Одинаковi");
            }
            else
            {
                Console.WriteLine("Рiзнi");
            }
            Console.WriteLine("Введiть висоту бажаної пiрамiди");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введiть довжини двох катетiв через Enter");
            double firstkp = Convert.ToDouble(Console.ReadLine());
            double secondkp = Convert.ToDouble(Console.ReadLine());
            TRPiramid piram = new TRPiramid();
            TRPiramid piram2 = new TRPiramid(firstkp, secondkp, height);
            TRPiramid piramc = new TRPiramid(piram2);
            TRPiramid pirm = piram2 * 2;
            Console.WriteLine($"Пiрамiда за замовчуванням: " + piram);
            Console.WriteLine($"Пiрамiда введена користувачем: " + piram2);
            Console.WriteLine($"Копiя пiрамiди введеної користувачем: " + piramc);
            Console.WriteLine($"Введена користувачем пiрамiда помножена на число: " + pirm);

            if (piram == pirm)
            {
                Console.WriteLine("Одинаковi");
            }
            else
            {
                Console.WriteLine("Рiзнi");
            }
        }
    }
}
