﻿double p = 3.14;
double y;
Console.WriteLine("Enter x: ");
double x = Convert.ToDouble(Console.ReadLine());
if (x <= 5 && x >= 1) {
    y = Math.Log(x) + Math.Pow(Math.Cos(Math.Pow(x, 2)), 2);
    Console.WriteLine($"Answer: {y}");
}
if (x == p)
{
    y=Math.Pow(Math.Sin(x), 2);
    Console.Write($"Answerd: {y}");
}