Console.WriteLine("Enter character: ");
string endCharacter = Console.ReadLine();
string[] mass = Console.ReadLine().Split(' ').Where(p => p.EndsWith(endCharacter)).ToArray();
for (int i = 0; i < mass.Length; i++)
{
    Console.WriteLine(mass[i]);
}
Console.ReadKey();