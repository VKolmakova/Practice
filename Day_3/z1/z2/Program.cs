using z2;

class Program
{
    static void Main()
    {
        Console.WriteLine("1.Great Britan \n2.Belarus \n3.Denmark ");
        Console.Write("Enter number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        switch (num)
        {
            case 1:
                Monarchy monarchy = new Monarchy("Great Britain", "Charles Philip Arthur George", 1922, "London", "Monarchy");
                monarchy.GiveInformation();
                monarchy.TitleTransfer();
                break;
            case 2:
                Republic republic = new Republic("Belarus", "Alexander Lukashenko", 1991, "Minsk", "Republic");
                republic.GiveInformation();
                republic.CallReferendum();
                break;
            case 3:
                Kingdom kingdom = new Kingdom("Denmark", "Margrethe Alexandrina Thorhildur Ingrid", 1523, "Copenhagen", "Kingdom");
                kingdom.GiveInformation();
                kingdom.TitleTransfer();
                break;

        }

    }
}
