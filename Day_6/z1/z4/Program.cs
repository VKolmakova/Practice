int floors = 12;
int apartments = 4;
Random rand = new Random();

int[,] house = new int[floors, apartments];
for (int f = 0; f < floors; f++)
{
    for (int a = 0; a < apartments; a++)
    {
        house[f, a] = rand.Next(1, 9);
        Console.Write(house[f, a] + "  ");
    }
    Console.WriteLine();
}

GetMost(house, 3, apartments);
GetMost(house, 4, apartments);

Console.ReadKey();
static void GetMost(int[,] house, int floor, int apartments)
{
    int max = 0;
    for (int a = 0; a < apartments; a++)
        if (house[floor - 1, a] > max)
            max = house[floor - 1, a];

    Console.WriteLine($"On the {floor} floor in the largest family {max} people");
}