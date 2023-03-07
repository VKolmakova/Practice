using _2;
Console.Write("Enter а: ");
double a1 = double.Parse(Console.ReadLine());
Console.Write("Enter b: ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Enter d: ");
double d1 = double.Parse(Console.ReadLine());
A a = new A();
A b = new A();
B d = new B(a1, b1, d1);

Console.WriteLine($"Sum = {d.c2}");