namespace z3;
internal class MyInfo
{
    delegate void ChangingInformation();
    event ChangingInformation ciEvent;

    private string name;

    public string Name
    {
        get => name;
        set
        {
            if (name != value)
            {
                name = value;
                ciEvent?.Invoke();
            }
        }
    }
    public MyInfo(string name)
    {
        this.name = name;
        ciEvent += delegate ()
        {
            Console.WriteLine("Name has been changed");
        };
    }
}

