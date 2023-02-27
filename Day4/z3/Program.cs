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
            F(i, out double y);
            Console.WriteLine($"f({i})={y}");
        }
    }
    static void F(double x, out double y)
    {
        y = 0;
        if (x == 1 || x == -1) y = 1;
        if (x >= 0 && x != 1) y = (1 / (1 - x));
        if (x < 0 && x != -1) y = (1 / (1 + x));
    }
}