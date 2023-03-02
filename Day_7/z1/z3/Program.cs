Console.Write("Enter text:  ");
string text = Console.ReadLine();
string[] words = text.Split(' ');
words[1] += words[2];
words = SwapFirstWithSecond(words);
words[2].Reverse();
words[0] = words[0].Remove(0, 2);

foreach (string word in words)
{
    Console.Write($"{word} ");
}

string[] SwapFirstWithSecond(string[] arr)
{
    (arr[0], arr[arr.Length - 1]) = (arr[arr.Length - 1], arr[0]);
    return arr;
}