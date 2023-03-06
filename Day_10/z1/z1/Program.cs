using System.Data.Common;
using System.Reflection.Metadata;

interface Ix
{
    void IxF0(double parameter);
    void IxF1();
}

interface Iy
{
    void F0(double parameter);
    void F1();
}

interface Iz
{
    void F0(double parameter);
    void F1();
}

class TestClass : Ix, Iy, Iz
{
    public double w;

    public void F0(double parameter)
    {
        Console.WriteLine("Result of implicit method implementation F0: " + Math.Sqrt(parameter));
    }

    public void F1()
    {
        Console.WriteLine("Result of implicit method implementation F1");
    }

    public void IxF0(double parameter)
    {
        Console.WriteLine("Result of implicit method implementation IxF0: " + Math.Pow(parameter, 2));
    }

    public void IxF1()
    {
        Console.WriteLine("Result of implicit method implementation IxF1");
    }
    void Iz.F0(double parameter)
    {
        Console.WriteLine("The result of the explicit implementation of the F0 method: " + ((parameter * parameter) + 5));
    }
    void Iz.F1()
    {
        Console.WriteLine("The result of the explicit implementation of the F0 method F1");
    }
}

class Program
{
    static void Main(string[] args)
    {
        TestClass obj = new TestClass();
        obj.w = 7.0;
        Ix objIx = obj;
        objIx.IxF0(obj.w);
        objIx.IxF1();

        Iy objIy = obj;
        objIy.F0(obj.w);
        objIy.F1();

        Iz objIz = obj;
        objIz.F0(obj.w);
        objIz.F1();
        IxF0((double)obj.w);
    }
    static void IxF0(double parameter)
    {
        TestClass obj = new TestClass();
        Ix objIx = obj;
        objIx.IxF0(parameter);
    }
}
