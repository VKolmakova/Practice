int[] array = new int[] {1,2,3,4,5,6};
foreach (int i in array)
{
    Console.Write($"{i} ");
}
Console.WriteLine();
Console.WriteLine("Answer: ");
for (int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0)
    {
        array[i] = 0;
    }
    Console.Write(array[i] + " ");
}