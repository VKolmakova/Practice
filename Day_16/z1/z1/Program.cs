using z1;
MyList<int> myList = new MyList<int>();
myList.Add(13);
myList.Add(7);
myList.Add(23);
myList.Add(4);

Console.WriteLine("Array:");
for (int i = 0; i < myList.Count; i++)
{
    Console.Write(myList[i] + " ");
}

Console.WriteLine("\nEnter element index:");
int index = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Element at index {index} : {myList[index]} ");
Console.WriteLine($"Amount of elements: {myList.Count}");
Console.WriteLine();
Console.WriteLine("Challenge a static method: ");
WriteArray(MyList<int>.GetArray(myList));


void WriteArray<T>(T[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}