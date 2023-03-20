void Sum(int n, ParallelLoopState pls)
{
    int result = 0;
    for (int i = 0; i <= n; i++)
    {
        if (result >= 10)

        {
            Console.WriteLine($"Sum = {result}");
            pls.Break();
            break;
        }
        result += i;
    }

}
void Mul(int n, ParallelLoopState pls)
{
    int result = 1;
    for (int i = 1; i < n; i++)
    {
        if (result >= 10)
        {
            Console.WriteLine($"Product of numbers = {result}");
            pls.Break();
            break;
        }
        result *= i;
    }
}


ParallelLoopResult result = Parallel.ForEach<int>(new List<int>() { 47, 16, 34, 87, 23 }, Sum);
ParallelLoopResult result2 = Parallel.ForEach<int>(new List<int>() { 47, 16, 34, 87, 23 }, Mul);
if (!result.IsCompleted)
    Console.WriteLine($"Loop execution completed at iteration {result.LowestBreakIteration}");