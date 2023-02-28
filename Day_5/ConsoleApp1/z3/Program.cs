namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter real number A1: ");
                double a1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter real number B1: ");
                double b1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter real number C1: ");
                double c1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter real number A2: ");
                double a2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter real number B2: ");
                double b2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter real number C2: ");
                double c2 = Convert.ToDouble(Console.ReadLine());
                SortDec3(a1, b1, c1);
                SortDec3(a2, b2, c2);
                Console.ReadLine();
            }
             catch (FormatException error)
            {
                Console.WriteLine("No value entered"+error.Message);
            }
            Console.ReadLine();
        }
        public static void SortDec3 (double a, double b, double c)
        {
            double[] nums = new double[] {a,b,c};

            var orderedNumbers = from i in nums
                                 orderby i descending
                                 select i;
            Console.WriteLine();
            foreach (double i in orderedNumbers)
                Console.Write($"{ i}  ");
        }
    }
}