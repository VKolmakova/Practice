using System;

namespace ConsoleApplication1
{
    class Class1
    {
        static void F(double a, double b, int m)
        {
            Console.WriteLine("Введите х");
            double x = Convert.ToDouble(Console.ReadLine());
            double h = (b - a) / m;
            for (double i = a; i <= b; i += 0.1)
            {
                Console.WriteLine(Math.Sin(Math.Pow(x, 2)));
                x += h;
            }
        }
        static void Main()
        {
            F(Math.PI / 6, 2*Math.PI / 3, 10);
        }
    }
}