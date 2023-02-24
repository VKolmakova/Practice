class A
{
   public  int a;
   public int b;
    public A (int a, int b)
    {
        this.a = a;
        this.b = b;
    }
    public double GetArithmeticMean() => 1 / Math.Pow(a, 2);
    public double CubSumOfNumbers() => Math.Pow((a+b),3);

}
class Program
{
    static void Main()
    {
        Console.Write("Enter а: ");
        int numA = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter b: ");
        int numB = Convert.ToInt32(Console.ReadLine());

        A a = new A(numA, numB);

        Console.WriteLine($"Computing the value of the expression = {a.GetArithmeticMean()}");
        Console.WriteLine($"Erection in the cube of the sum of a and b = {a.CubSumOfNumbers()}");
    }
}