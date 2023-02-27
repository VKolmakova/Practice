using z4;

{
    static void Main(string[] args)
        {
            int N = 3;
            Random rand = new Random();
            Matrix first = new Matrix(N);
            Matrix second = new Matrix(N);

            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                {
                    first[i, j] = rand.Next(1, 5);
                    second[i, j] = rand.Next(1, 5);
                }
            Console.WriteLine("First matrix :\n\n");
            first.PrintMatrix();
            Console.WriteLine("\n\nSecond matrix:\n\n");
            second.PrintMatrix();
            Console.WriteLine("\n\nMatrix sum :\n\n");
            (first + second).PrintMatrix();
            Console.WriteLine("\n\nMatrix difference:\n\n");
            (first - second).PrintMatrix();
            Console.ReadKey();
        }
    }
}