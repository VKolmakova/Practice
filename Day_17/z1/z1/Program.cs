using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("Enter the number of digits in the source file (f): ");
            int n = int.Parse(Console.ReadLine());
            int r;

            File.WriteAllText("D:\\Valya\\collage\\f.txt", "");
            File.WriteAllText("D:\\Valya\\collage\\g.txt", "");
            for (int i = 0; i < n; i++)
            {
                r = rand.Next(0, 100);
                File.AppendAllText("D:\\Valya\\collage\\f.txt", r + " ");
            }

            FileStream f = new FileStream("D:\\Valya\\collage\\f.txt", FileMode.Open
            , FileAccess.Read);
            FileStream g = new FileStream("D:\\Valya\\collage\\g.txt", FileMode.Open
            , FileAccess.Write);
            StreamReader rf = new StreamReader(f, Encoding.UTF8);
            StreamWriter wg = new StreamWriter(g, Encoding.UTF8);

            string str = File.ReadAllText("D:\\Valya\\collage\\f.txt");
            int[] arr = str
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(m => int.Parse(m))
                .ToArray();

            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 3 == 0 && arr[i] % 7 != 0)
                {

                    string z = arr[i] + " ";
                    wg.Write(z);
                }
            }

            wg.Close();
        }
    }
}