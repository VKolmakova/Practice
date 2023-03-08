public delegate int Number();
public delegate int Calc(Number[] arrayX);
class Program
{
    public static int Randomizer()
    {
        Random rand = new Random();
        return rand.Next(1, 5);
    }
    static void Main(string[] args)
    {
        Func<int>[] numArr = new Func<int>[5];
        Console.Write("Array: ");

        for (int i = 0; i < numArr.Length; i++)
        {
            numArr[i] = Randomizer;

            Console.Write(" " + numArr[i].Invoke() + " ");
        }
        Console.WriteLine();
        var mediumCalc = delegate (Func<int>[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i]();
            }
            return ((sum) / (array.Length));
        };
        Console.WriteLine($"The arithmetic mean = {mediumCalc(numArr)}"); ; ;
        Console.ReadKey();
    }
}

