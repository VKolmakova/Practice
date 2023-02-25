public class State
{
    private string typeOfGoverment;
    private string name;
    private string ruler;
    private int yearOfFoundation;
    private string capital;
    public string Name { get { return name; } set { name = value; } }
    public string Ruler { get { return ruler; } set { ruler = value; } }
    public decimal YearOfFoundation { get { return yearOfFoundation; } set { yearOfFoundation = (int)value; } }
    public string Capital { get { return capital; } set { capital = value; } }
    public string TypeOfGoverment { get { return typeOfGoverment; } set { typeOfGoverment = value; } }

    protected State(string name, string ruler, int yearOfFoundation, string capital, string typeOfGoverment)
    {
        this. name = name;
        this.ruler = ruler;
        this.yearOfFoundation = yearOfFoundation;
        this.capital = capital;
        this.typeOfGoverment = typeOfGoverment;
     
    }
    public void giveInformation()
    {
        Console.WriteLine($"{name} is {typeOfGoverment}\nThe ruler is {ruler} \nYear of foundation: {yearOfFoundation} \nCapital: {capital}");
    }
}
public class Republic : State

{
    public Republic(string name, string ruler, int yearOfFoundation, string capital, string typeOfGoverment) : base(name, ruler, yearOfFoundation, capital, typeOfGoverment)
    {
    }
    public void callReferendum()
    {
        Console.WriteLine("Referendum scheduled for February 27, 2022");
    }
}
    
   
public class Monarchy : State
{
    public Monarchy(string name, string ruler, int yearOfFoundation, string capital, string typeOfGoverment) : base(name, ruler, yearOfFoundation,capital,typeOfGoverment)
    {
    }
    public void titleTransfer()
    {
        Console.WriteLine("In 2022, Elizabeth II transferred the title to Charles III");
    }
  
}
public class Kingdom : State
{
    public Kingdom(string name, string ruler, int yearOfFoundation, string capital, string typeOfGoverment) : base(name, ruler, yearOfFoundation,capital,typeOfGoverment)
    {
    }
    public void titleTransfer()
    {
        Console.WriteLine("Margrethe II is reigning queen of Denmark from the Glücksburg dynasty since 14 January 1972, after the death of her father King Frederick IX");
    }
}
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
                monarchy.giveInformation();
                monarchy.titleTransfer();
                break;
            case 2:
                Republic republic = new Republic("Belarus", "Alexander Lukashenko", 1991, "Minsk", "Republic");
                republic.giveInformation();
                republic.callReferendum();
                break;
            case 3:
                Kingdom kingdom = new Kingdom("Denmark", "Margrethe Alexandrina Thorhildur Ingrid", 1523, "Copenhagen", "Kingdom");
                kingdom.giveInformation();
                kingdom.titleTransfer();
                break;

        }

    }
}
