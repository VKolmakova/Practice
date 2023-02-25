public class State
{
    private string typeOfGoverment;
    private string name;
    private string ruler;
    private int yearOfFoundation;
    private string capital;

    protected State(string name, string ruler, int yearOfFoundation, string capital, string typeOfGoverment)
    {
        this.name = name;
        this.ruler = ruler;
        this.yearOfFoundation = yearOfFoundation;
        this.capital = capital;
        this.typeOfGoverment = typeOfGoverment;

    }
    public void GiveInformation()
    {
        Console.WriteLine($"{name} is {typeOfGoverment}\nThe ruler is {ruler} \nYear of foundation: {yearOfFoundation} \nCapital: {capital}");
    }
}