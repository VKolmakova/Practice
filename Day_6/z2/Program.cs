int[] array = new int[] { 3, 2, 12, -4, -3 };
bool check = true;
    for (int i = 1; i < array.Length-1; i++)
    {
        if (array[i] % 2 == 0 && array[i - 1] % 2 == 1)
        {
            check = false;
            break;
        }
    }
    for (int i = 0; i < array.Length; i++)
    {
        if (check && array[i] < 0 || !check && array[i] > 0)
    Console.Write($"{array[i]} ");
    }
