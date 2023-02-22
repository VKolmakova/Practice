Console.WriteLine("Enter funt: ");
double funt = double.Parse(Console.ReadLine());
int gramsInKg = 1000;
double gramsInFunt = 409.5;
double kgInFunt = gramsInFunt / gramsInKg;
Console.WriteLine(funt + " funt in kg =  " + funt * kgInFunt);