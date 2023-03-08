Console.Write("Enter string: ");
string str = Console.ReadLine();


WorkerString ws = ToLower;
ws += ToUpper;
ws += RemoveLastWord;

Console.WriteLine($"\r\nExecution result: {ws(str)}");


static string ToUpper(string str) => str.ToUpper();
static string ToLower(string str) => str.ToLower();
static string RemoveLastWord(string str) => str.Remove(str.LastIndexOf(' '));

delegate string WorkerString(string str);
