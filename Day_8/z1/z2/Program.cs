using System.Text.RegularExpressions;

Console.Write("Enter text :");
string text = Console.ReadLine();

if (CheckWhetherHTMLCode(text))
{
    Console.WriteLine("Text is HTML code");
}
else
{
    Console.WriteLine("Text is not HTML code");
}

bool CheckWhetherHTMLCode(string text)
{
    string[] arrayHTMLTag = { "<html>", "<form>", "<h1>" };
    for (int i = 0; i < arrayHTMLTag.Length; i++)
    {
        Regex regex = new Regex(arrayHTMLTag[i]);
        if (regex.Matches(text).Count > 0)
        {
            return true;
        }
    }
    return false;
}