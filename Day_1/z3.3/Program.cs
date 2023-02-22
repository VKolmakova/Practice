Console.Write("Enter number: ");
double number = Convert.ToDouble(Console.ReadLine());
double z1 = Math.Sin(2 * number) + Math.Sin(5 * number) - Math.Sin(3 * number);
double z2 = 2 * Math.Sin(number);
Console.WriteLine($"First answer = {z1}");
Console.Write($"Second answer = {z2}");

