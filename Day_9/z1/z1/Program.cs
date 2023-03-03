using z1;

class Program
{

    static void Main(string[] args)
    {
        int n = 2;
        List<Note> noteList = new List<Note>();
        for (int i = 0; i < n; i++)
        {
            noteList.Add(CreateNote());
        }
        Console.WriteLine();
        Console.WriteLine("Information in the database: ");
        Console.WriteLine();
        PrintNoteList(SortByAlphabet(noteList));

        Console.WriteLine("Enter month: ");
        int month = Convert.ToInt32(Console.ReadLine());
        List<Note> found = FoundByMounth(noteList, month);

        if (found.Count != 0) PrintNoteList(found);
        else Console.WriteLine("Absent");
        Console.ReadKey(true);
    }

    public static Note CreateNote()
    {
        Console.Write("Surname and first name: ");
        string surnameAndFirstName = Convert.ToString(Console.ReadLine());
        Console.Write("Phone number: ");
        string notesOfPeoplePersonalData = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Date of Birth (only numbers): ");
        Console.Write("Day: ");
        int day = Convert.ToInt32(Console.ReadLine());
        Console.Write("Month: ");
        int mounth = Convert.ToInt32(Console.ReadLine());
        Console.Write("Year: ");
        int year = Convert.ToInt32(Console.ReadLine());
        return new Note(surnameAndFirstName, notesOfPeoplePersonalData, new int[3] { day, mounth, year });
    }

    public static List<Note> FoundByMounth(List<Note> noteList, int mounth)
    {
        List<Note> found = new List<Note>();
        foreach (Note note in noteList)
        {
            int peopleMounthOfBirth = note.dateoOfBirth[1];
            if (peopleMounthOfBirth == mounth)
            {
                found.Add(note);
            }
        }
        return found;
    }

    public static void PrintNoteList(List<Note> noteList)
    {
        foreach (Note note in noteList)
        {
            Console.WriteLine(note.ToString());
        }
    }

    public static List<Note> SortByAlphabet(List<Note> noteList)
    {
        noteList.Sort((x, y) => string.Compare(x.surnameAndFirstName, y.surnameAndFirstName));
        return noteList;
    }
}