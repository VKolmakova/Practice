Console.Write("Enter initial value: ");
int initialValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter final value: ");
double finalValue = Convert.ToInt32(Console.ReadLine());
if (initialValue > finalValue)
{
    Console.WriteLine("Error: start value must be greater than or equal to end value");
}
int i = initialValue;
for (; i <= finalValue; i++)
{
    if (i % 3 == 0)
    {
        Console.Write($"{i} ");
    }
}
Console.WriteLine();
i = initialValue;
while (i <= finalValue)
{
    if (i % 3 == 0)
        Console.Write(i + " ");
    i++;
}
Console.WriteLine();
i = initialValue;
do
{
    if (initialValue == finalValue)
        break;
    if (i % 3 == 0)
        Console.Write(i + " ");
    i++;
}
while (i <= finalValue);
Console.ReadKey();
