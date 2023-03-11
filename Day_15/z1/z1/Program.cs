using System.Threading;
static void FirstThread()
{  
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine(i);
    
        Thread.Sleep(10);
    }

}
static void SecondThread()
{
    for (int i = 10; i < 20; i++)
    {
        Console.WriteLine(i);
        Thread.Sleep(10);
    }

}
static void ThirdThread()
{
    for (int i = 20; i < 30; i++)
    {
        Console.WriteLine(i);
        Thread.Sleep(10);
    }

}
Thread thread1 = new Thread(FirstThread);
Thread thread2 = new Thread(SecondThread);
Thread thread3 = new Thread(ThirdThread);

thread1.Priority = ThreadPriority.Highest;
thread2.Priority = ThreadPriority.Normal;
thread3.Priority = ThreadPriority.Lowest;

thread1.Start();
thread1.Join();

thread2.Start();
thread2.Join();

thread3.Start();
thread3.Join();
