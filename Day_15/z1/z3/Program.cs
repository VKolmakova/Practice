using _3;
using System.Threading;

void ExponentiationInAddition(object obj)
{
    if (obj is Params myparams)
    {
        double exp = 0;
        for (double i = myparams.A; i < myparams.N; i++)
        {
            exp += Math.Pow(myparams.A, myparams.N);
        }
        Console.WriteLine(exp);
        Thread.Sleep(10);
    }

}
object locker = new object();
void ExponentiationInMultiplication(double a, double n)
{
    lock (locker)
    {
        double exp = 1;
        for (double i = a; i < n; i++)
        {
            exp += exp * Math.Pow(a, n);
        }
        Console.WriteLine(exp);
        Thread.Sleep(10);
    }
}

Console.Write("Enter a: ");
double a = double.Parse(Console.ReadLine());

Console.Write("Enter n: ");
double n = double.Parse(Console.ReadLine());

Params myparams = new Params() { A = a, N = n };
Thread thread1 = new Thread(ExponentiationInAddition);
thread1.Name = "Thread 1";
Thread thread2 = new Thread(ExponentiationInAddition);
thread1.Name = "Thread 2";

Thread thread3 = new Thread(() => ExponentiationInMultiplication(a, n));
thread3.Name = "Thread 1";
Thread thread4 = new Thread(() => ExponentiationInMultiplication(a, n));
thread4.Name = "Thread 2";

thread1.Start(myparams);
thread1.Join();

thread2.Start(myparams);
thread2.Join();

thread3.Start();
thread4.Start();