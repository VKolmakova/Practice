using z1;
class Program
{
    static void Main()
    {
        Console.Write("Enter a: ");
        int numA = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter b: ");
        int numB = Convert.ToInt32(Console.ReadLine());

        A a = new A(numA, numB);

        Console.WriteLine($"Computing the value of the expression = {a.GetArithmeticMean()}");
        Console.WriteLine($"Erection in the cube of the sum of a and b = {a.CubSumOfNumbers()}");
    }
}