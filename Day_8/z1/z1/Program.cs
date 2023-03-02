using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter string : ");
//        string date = new string(Console.ReadLine());
//        FindData(date);

//        static void FindData(String date)
//        {
//            string dataRegex = @"\d{2}.\d{2}.\d{4}";
//            {
//                if (Regex.IsMatch(date, dataRegex))
//                {
//                    Console.WriteLine("True");
//                }
//                else Console.WriteLine("False");
//            }

//        }
//    }
//}
using System.Text.RegularExpressions;

string pattern = @"([0-1][1-9]|2[0-9]|3[0-1]).(0[1-9]|1[0-2]).([1-2]+0+[0-1]+[0-9]|[1-2]+02+[0-3])";
string input = Console.ReadLine();

if (Regex.IsMatch(input, pattern))
{
    Console.WriteLine("Работает");
}
else Console.WriteLine("Не работает!");