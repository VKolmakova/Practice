using Model;

string name = Print("Phone name: ");
int year = Convert.ToInt32(Print("Year of issue: "));
Phonebrand genere = (Phonebrand)Enum.Parse(typeof(Phonebrand), Print("Enter brand: "));
string nameCompany = Print("Company name: ");
int numOfCopiesSold = Convert.ToInt32(Print("Number of copies sold: "));
decimal cost = Convert.ToDecimal(Print("Price: "));
Phone phone = new Phone(name, year, genere, new Company(nameCompany),
    numOfCopiesSold, cost);
Console.WriteLine();
Console.WriteLine(phone);

string Print(string mes = "")
{
    Console.Write(mes);
    return Console.ReadLine();
}