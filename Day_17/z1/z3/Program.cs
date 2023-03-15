class Program
{
    static void Main(string[] args)
    {
        List<string> lines = new List<string>();

        using (StreamWriter sw = new StreamWriter("D:\\Valya\\collage\\Hello I like cat.txt"))
        {
            sw.WriteLine("I have a cat, his name is Bulka");
            sw.WriteLine("His breed is a golden British chinchilla");
            sw.WriteLine("He's 2 years old");
            sw.WriteLine("I have a chinchilla");
            sw.WriteLine("He's 6 years old");
        }

        using (StreamReader sr = new StreamReader("D:\\Valya\\collage\\Hello I like cat.txt"))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                lines.Add(line);
            }
        }

        // a)
        Console.WriteLine("File contents:");
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

        // b)
        Console.WriteLine();
        int numLines = lines.Count;
        Console.WriteLine("Number of lines: {0}", numLines);

        // c)
        Console.WriteLine();
        Console.WriteLine("Number of characters per line:");
        foreach (string line in lines)
        {
            Console.WriteLine("{0}: {1}", line, line.Length);
        }

        // d)
        Console.WriteLine();
        string lastLine = lines[numLines - 1];
        lines.RemoveAt(numLines - 1);
        using (StreamWriter sw = new StreamWriter("D:\\Valya\\collage\\fileWithDeletedLine.txt"))
        {
            foreach (string line in lines)
            {
                sw.WriteLine(line);
            }
        }
        Console.WriteLine("Deleted line: {0}", lastLine);

        // e)
        Console.WriteLine();
        int s1 = 2;
        int s2 = 4;
        Console.WriteLine("Lines {0} to {1}:", s1, s2);
        for (int i = s1 - 1; i < s2; i++)
        {
            Console.WriteLine(lines[i]);
        }

        // f)
        Console.WriteLine();
        int maxLength = 0;
        foreach (string line in lines)
        {
            if (line.Length > maxLength)
            {
                maxLength = line.Length;
            }
        }
        Console.WriteLine("The longest string is {0} characters long.", maxLength);

        // g)
        Console.WriteLine();
        char startingChar = 'I';
        Console.WriteLine("Lines starting with the letter '{0}':", startingChar);
        foreach (string line in lines)
        {
            if (line.StartsWith(startingChar.ToString()))
            {
                Console.WriteLine(line);
            }
        }

        // h)
        Console.WriteLine();
        lines.Reverse();
        using (StreamWriter sw = new StreamWriter("D:\\Valya\\collage\\reversed.txt"))
        {
            foreach (string line in lines)
            {
                sw.WriteLine(line);
            }
        }
        Console.WriteLine("The lines are written in reverse order to the file 'reversed.txt'.");
    }
}



