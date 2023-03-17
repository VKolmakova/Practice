using Library;

Triangle triangle = InputTrianlge();

Console.WriteLine("Triangle");
Console.WriteLine ("Perimetr:"+ triangle.Perimeter());
Console.WriteLine("Square:"+ triangle.Square());
Console.WriteLine($"Type:" + triangle.TypeTriangle());
Console.WriteLine();
Rectangle rectangle = InputRectangle();
Console.WriteLine("Rectangle");
Console.WriteLine("Squre: " + rectangle.Square());
Console.WriteLine("Perimeter: " + rectangle.Perimeter());

Rectangle InputRectangle()
{
    Console.WriteLine("Enter side a: ");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter side b: ");
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter side c: ");
    int c = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter side d: ");
    int d = int.Parse(Console.ReadLine());

    var rectangle = new Rectangle(a,b,c,d);
    return rectangle;
}

Triangle InputTrianlge()
{
    Console.WriteLine("Enter side a: ");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter side b: ");
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter side c: ");
    int c = int.Parse(Console.ReadLine());

    var triangle = new Triangle(a, b, c);
    return triangle;
}
void PrintResults(string message, Func<double> function)
{
    Console.WriteLine($"{message} {function}");
}
