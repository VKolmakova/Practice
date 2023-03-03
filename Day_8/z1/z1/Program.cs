using System.Text.RegularExpressions;
string input = Console.ReadLine();
Regex  regex = new Regex (@"([0-1][1-9]|2[0-9]|3[0-1]).(0[1-9]|1[0-2]).([1-2]+0+[0-1]+[0-9]|[1-2]+02+[0-3])");
MatchCollection words = regex.Matches(input);

if (words.Count > 0)
{
    foreach (Match word in words)
    {
        Console.WriteLine(word.Value);
    }
}
else
{
    Console.WriteLine("No data");
}