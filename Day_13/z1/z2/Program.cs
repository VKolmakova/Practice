using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int Func(int a, int b);
class Program
{
    static void Main()
    {

        Func<int, int, int> f = (a, b) => a + b;
        Func g = (a, b) => a - b;
        Func h = (a, b) => a * b;
        Func i = (a, b) => a / b;
        Console.WriteLine("Enter a: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter b: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Choose an operation: \n1.Add \n2.Sub \n3.Mul\n4.Div");
        string c = Console.ReadLine();

        switch (c)
        {
            case "1":
                Console.WriteLine($"Expression = {f(a, b)}");
                break;
            case "2":
                Console.WriteLine($"Expression = {g(a, b)}");
                break;
            case "3":
                Console.WriteLine($"Expression = {h(a, b)}");
                break;
            case "4":
                Console.WriteLine($"Expression = {i(a, b)}");
                if (b == 0)
                {
                    Console.WriteLine("You can't divide by zero!");
                }
                break;
            default:
                Console.WriteLine("No such operation");
                break;
        }
    }
}