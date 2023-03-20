Console.Write("Enter a:");
double a = double.Parse(Console.ReadLine());

Task[] tasks1 = new Task[2]
{
new Task(() =>Console.WriteLine( ResultFuncZ1(a, 2000))),

new Task(() => Console.WriteLine(  ResultFuncZ2(a,5000)))
};
foreach (var t in tasks1)
    t.Start();
Task.WaitAny(tasks1);
Console.WriteLine("First");
Task.WaitAll(tasks1);
Console.WriteLine("End");

double ResultFuncZ2(double a, int milliseconds)
{

    Thread.Sleep(milliseconds);
    return 2*Math.Sin(a);
}

double ResultFuncZ1(double a, int milliseconds)
{
    Thread.Sleep(milliseconds);
    return (Math.Sin(2*a)+Math.Sin(5*a)-Math.Sin(3*a))/(Math.Cos(a)+1-2* Math.Pow(Math.Sin(2*a),2));
}
