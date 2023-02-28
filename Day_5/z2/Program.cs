namespace z2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double f;
                Console.WriteLine("Enter a real number x: ");
                double x = Convert.ToDouble(Console.ReadLine());

                if (x < 1 && x > 0)
                {
                    f = x * Math.Cos(x);
                    Console.WriteLine(f);
                }
                else if (1 >= x)
                {
                    f = 12 / (3 * x - 3);
                    Console.WriteLine(f);
                }
                else throw new Exception("Error: out of range of acceptable x values");
            }
            catch (DivideByZeroException error)
            {
                Console.WriteLine("Division by zero is prohibited" + error.Message);
            }
            catch (FormatException error)
            {
                Console.WriteLine("No value entered"+error.Message);
            }
            finally
            {
                Console.WriteLine("End of program");
            }
            Console.ReadLine();
        }
    }
}