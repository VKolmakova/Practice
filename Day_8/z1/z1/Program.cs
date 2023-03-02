using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter string : ");
        string date = new string(Console.ReadLine());
        FindData(date);

        static void FindData(String date)
        {
            string dataRegex = @"\d{2}.\d{2}.\d{4}";
            {
                if (Regex.IsMatch(date, dataRegex))
                {
                    Console.WriteLine("True");
                }
                else Console.WriteLine("False");
            }
            
        }
    }
}