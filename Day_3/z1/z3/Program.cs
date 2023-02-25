class Drob
{
    int chislitel;
    int znamenatel;

    public Drob() { }

    public Drob(int chislit, int znamenat)
    {
        chislitel = chislit;
        znamenatel = znamenat;
    }

    public int Chislitel
    {
        get { return chislitel; }
        set { chislitel = value; }
    }

    public int Znamenatel
    {
        get { return znamenatel; }
        set { znamenatel = value; }
    }

    public static Drob Plus(Drob drob1, Drob drob2)
    {
        Drob dr = new Drob();

        if (drob1.Znamenatel != drob2.Znamenatel)
        {
            dr.Chislitel = drob1.Chislitel * drob2.Znamenatel + drob2.Chislitel * drob1.Znamenatel;
            dr.Znamenatel = drob1.Znamenatel * drob2.Znamenatel;
        }
        else
        {
            dr.Chislitel = drob1.Chislitel + drob2.Chislitel;
            dr.Znamenatel = drob1.Znamenatel;
        }
        return dr;
    }
}
