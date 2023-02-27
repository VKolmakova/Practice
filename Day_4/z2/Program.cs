namespace z2
{
    class Program
    {
      
        static void Main(string[] args)
        {
            double x; double a; double b; double h;

            Console.Write("a=: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("b=: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("h=: ");
            h = double.Parse(Console.ReadLine());
            for (double i = a; i <= b; i += h)
            {
                Console.Write($"f({i})={F(i)}");
            }
        }
        static double F(double x)
        {
            double y = 0;
            if (x == 1 || x == -1) y = 1;
            if (x >= 0 && x != 1) y = (1 / (1 - x));
            if (x < 0 && x != -1) y = (1 / (1 + x));
            return y;
        }
    }
}