class Program
{ ///<summary>
  ///Метод Main точка входа.
  /// </summary>

    static void Main(string[] args)
    {///<summary>
     ///Объявленение переменных
     /// </summary>
        double x; double a; double b; double h;
        ///<summary>
        ///Инициализация переменных
        /// </summary>
        Console.Write("a=: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("b=: ");
        b = double.Parse(Console.ReadLine());
        Console.Write("h=: ");
        h = double.Parse(Console.ReadLine());
        ///<summary>
        ///Цикл For, начинающийся с a и заканчивающийся при i равном b,выполняющий инкримент на h после каждой 
        ///интерации цикла, производит вывод на экран результата, с использованием метода F
        /// </summary>
        for (double i = a; i <= b; i += h)
        {
            F(i, out double y);
            Console.WriteLine($"f({i})={y}");
        }
    }
    /// <summary>
    /// Метод F с перегрузкой 
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    static void F(double x, out double y)
    {
        ///<summary>
        ///Инициализация переменной
        /// </summary>
        y = 0;
        if (x == 1 || x == -1) y = 1;
        if (x >= 0 && x != 1) y = (1 / (1 - x));
        if (x < 0 && x != -1) y = (1 / (1 + x));
    }
}