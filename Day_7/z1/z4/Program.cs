using System.Text;
namespace ConsoleApplication
{
    class Class
    {
        static string GetAplhabetString()
        {
            var str = new StringBuilder();
            for (char i = 'а'; i <= 'я'; i++)
            {
                str.Append(i.ToString());
            }
            return str.ToString();
        }

        public static int[] GetNumberCodes(string text)
        {
            char[] alfavit = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
            int[] array = new int[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                array[i] = Array.IndexOf(alfavit, text[i]) + 1;
            }
            return array;
        }
        public static int SumDigits(int Number)
        {
            int Sum = 0;
            while (Number > 0)
            {
                Sum += Number % 10;
                Number /= 10;
            }
            return Sum;
        }
        static void Main()
        {
            Console.WriteLine("Enter the string: ");

            string text = new string(Console.ReadLine()).Replace(" ", "").ToLower();

            int[] mas = GetNumberCodes(text);
            int sum = mas.Sum();
            Console.WriteLine("Sum of numbers : " + sum);
            while (sum > 9)
            {
                sum = SumDigits(sum);
            }
            Console.WriteLine("Personal code: " + sum);
        }
    }
}
