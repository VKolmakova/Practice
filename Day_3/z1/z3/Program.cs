using z3;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter first Numerator ");
        int firstNumerator = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter first Denominator ");
        int firstDenominator = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second Numerator ");
        int secondNumerator = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second Denominator ");
        int secondDenominator = Convert.ToInt32(Console.ReadLine());
        Fraction fraction = new Fraction(firstNumerator, firstDenominator, secondNumerator, secondDenominator);
        fraction.Multiply();
        fraction.Division();
        fraction.Sum();
        fraction.Subtraction();

    }
}



