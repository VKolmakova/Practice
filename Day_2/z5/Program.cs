Console.Write("Enter A (A >= 1): ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter B (A < B <= 10): ");
double b = Convert.ToInt32(Console.ReadLine());
double sum = 0;
if(a> b)
{
    Console.WriteLine("Error");
    Console.ReadKey();
}
for (double i = a; i <= b; i++)
{
    sum = sum + Math.Pow(i, 2);
}
Console.WriteLine($"Result = {sum} ");
