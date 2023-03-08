using z1;

Locality[] localities = new Locality[]
{
    new City("Гродно",357493, 142),
    new City("Минск", 1996553 ,348),
    new City ("Брест",1324027,146),
    new Village("Ивье",1000,6,15),
    new Village("Кореличи",1000,6,1096)
};

foreach (Locality locality in localities)
{
    Console.WriteLine($"Population density: {locality.GetPopulationDensity():.###}");
}
Console.Write("Lowest population density:");
Console.Write(Locality.GetMinPopulationDensity(localities));
