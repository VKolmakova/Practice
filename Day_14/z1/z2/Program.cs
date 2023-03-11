delegate int ArithmeticOperations(int firstNumber, int secondNumber);
class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter secondNumber: ");
            int secondNumber = int.Parse(Console.ReadLine());

            ArithmeticOperations ao = Addition;
            ao += Subtraction;
            ao += Division;

            Computing(firstNumber, secondNumber, ao);

            void Computing(int firstNumber, int b, ArithmeticOperations ao) => Console.WriteLine($"Result of delegate execution: {ao(firstNumber, secondNumber)}");

            static int Addition(int firstNumber, int secondNumber) => firstNumber + secondNumber;
            static int Subtraction(int firstNumber, int secondNumber) => firstNumber - secondNumber;
            static int Division(int firstNumber, int secondNumber) => firstNumber / secondNumber;
        }
        catch (FormatException fx)
        {
            Console.WriteLine(fx.Message);
        }
        catch (DivideByZeroException fx)
        {
            Console.WriteLine(fx.Message);
        }
        catch (Exception fx)
        {
            Console.WriteLine( fx.Message);
        }
        Console.ReadLine();
    }
}

