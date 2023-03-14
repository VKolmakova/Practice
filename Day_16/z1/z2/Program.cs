using z2;

MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();

myDictionary.Add(0, "Object 1");
myDictionary.Add(1, "Object 2");
myDictionary.Add(2, "Object 3");


for (int i = 0; i < myDictionary.Length; i++)
{
    Console.WriteLine(myDictionary[i]);
}
Console.WriteLine($"Size myDictionary: {myDictionary.Length}");
Console.WriteLine("Enter element index:");
int index = int.Parse(Console.ReadLine());
Console.WriteLine($"Element at index {index} : {myDictionary[index]} ");
Console.WriteLine($"Size myDictionary: {myDictionary.Length}");