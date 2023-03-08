CalcFigure cf = GetLength;
cf += GetArea;
cf += GetVolume;
Console.Write("Enter R: ");
int r = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Delegate execution result: {cf(r):.###}");

static double GetLength(double r) => 2 * Math.PI * r;
static double GetArea(double r) => Math.PI * r * r;
static double GetVolume(double r) => 4 / 3 * Math.PI * Math.Pow(r, 3);

delegate double CalcFigure(double R);