Console.Write("Enter N (N<10): ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter M: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] matrix = GetRandomMatrix(n, a, b);
WriteMatrix(matrix);
FindArithmeticMeanOfNumbers();
Console.WriteLine("The sum of the positive elements of each column:");
GetSumOfPositiveElementsColumn();

int[,] GetRandomMatrix(int n, int a, int b)
{
    int[,] matrix = new int[n, n];
    Random random = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = random.Next(a, b + 1);
        }
    }
    return matrix;
}

void WriteMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetUpperBound(0) + 1; i++)
    {
        for (int j = 0; j < matrix.GetUpperBound(1) + 1; j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}
void FindArithmeticMeanOfNumbers()
{
    List<int> numbers = new List<int>();
    int temp = 0;
    int result;
    for (int i = 0; i < matrix.GetUpperBound(0) + 1; i++)
    {
        for (int j = 0; j < matrix.GetUpperBound(1) + 1; j++)
        {
            if(matrix[i, j] < m)
            {
                numbers.Add(matrix[i, j]);
            }
        }
    }
    for (int i = 0; i < numbers.Count; i++)
    {
        temp = temp + numbers[i];
    }
    result = temp / numbers.Count;
    Console.WriteLine($"Arithmetic mean of numbers = {result}");
}
void GetSumOfPositiveElementsColumn()
{
    int [] sum = new int[n];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (matrix[j,i]>0)
            {
                sum[i] += matrix[j, i];
            }
        }
        Console.Write($"{sum[i]} ");
    }
}
