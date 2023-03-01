Console.Write($"Enter n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Factorial(1 + n) / Factorial(2 + n));

int Factorial(int num)
{
    if (num == 0)
    {
        return 1;
    }
    else
    {
        return num * Factorial(num - 1);
    }
}
