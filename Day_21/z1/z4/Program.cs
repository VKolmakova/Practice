static void Sin(int x)
{
    Console.WriteLine($"Expression = { Math.Sin(Math.Pow(x,2))}");
    Thread.Sleep(1000);
}
Console.Write("Enter х:");
int x = int.Parse(Console.ReadLine());
Parallel.For(-5, 16, Sin);