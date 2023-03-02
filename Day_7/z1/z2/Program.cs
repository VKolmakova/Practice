    Console.WriteLine("Enter word length: ");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter the string: ");
    string String = Console.ReadLine();

    string[] words = String.Split(' ', ',', '.', ':', '?');

    var sortWords = from s in words where s.Length == n orderby s select s;
    foreach (var s in sortWords)
        Console.WriteLine(s);

    Console.ReadKey(true);