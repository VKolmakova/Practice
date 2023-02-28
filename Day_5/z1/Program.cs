using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter x: ");
                int x = Convert.ToInt32(Console.ReadLine());
                double y1 = Math.Atan(x)/(x-3);
                Console.WriteLine("y1 = " + y1);
                double y2 = Math.Log(x)+((5*x-3)/(x-1));
                Console.WriteLine("y2 = " + y2);
            }
            catch (DivideByZeroException error)
            {
                Console.WriteLine("Division by zero is prohibited" + error.Message);
            }
            catch (FormatException error)
            {
                Console.WriteLine("No value entered" + error.Message);
            }
            finally
            {
                Console.WriteLine("End of program");
            }
            Console.ReadLine();

        }
    }
}