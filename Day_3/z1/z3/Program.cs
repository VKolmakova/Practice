class Fractions
{
    public int firstNumerator;
    public int firstDenominator;
    public int secondNumerator;
    public int secondDenominator;
 
    public Fractions(int firstNumerator, int firstDenominator, int secondNumeration, int secondDenominator)
    {
        this.firstNumerator = firstNumerator; //Numerator - числитель
        this.firstDenominator = firstDenominator; // Denominator - знаменатель
        this.secondNumerator = secondNumeration;
        this.secondDenominator = secondDenominator;
    }
    public void Multiply(int firstNumerator, int secondNumerator,int firstDenominator, int secondDenominator)
    {
        int numenator = (firstNumerator * secondNumerator);
        int denominator = (firstDenominator * secondDenominator);
        Console.WriteLine($"Fraction = {numenator} / {denominator}");
    }
}
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
        Fractions tmp = new Fractions(firstNumerator, firstDenominator, secondNumerator, secondDenominator);
        tmp.Multiply(firstNumerator, secondNumerator, firstDenominator, secondDenominator);
       

    }
}



