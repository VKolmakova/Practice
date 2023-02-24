public class State
{
  
    public string name;
    public string ruler;
    public State ()
    {
        this.name= String.Empty;
        Vvod();
    }
    void Vvod()
    {
        Console.WriteLine("Enter name of state: ");
        name = Console.ReadLine();
    }
    public virtual string Vivod()
    {
        return "Name of state : "+ name;
    }

}
public class Republic : State
{
    string name;
    string ruler;
    public Republic():base()
    {
        this.name = String.Empty;
        this.ruler = String.Empty;
        Input();
    }
    void Input()
    {
        Console.WriteLine();
    }
}
public class Monarchy : State
{
    public string name;
    public string ruler;
    public Monarchy() : base()
    {
        this.name = String.Empty;
        this.ruler = String.Empty;
    }
}
public class Kingdom : State
{
    public string name;
    public string ruler;
    public Kingdom() : base()
    {
        this.name = String.Empty;
        this.ruler = String.Empty;
    }
}
