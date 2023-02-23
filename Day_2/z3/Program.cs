Console.Write("Enter passenger number from 1 to 12: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 4 || number == 5 || number == 6 || number == 7 || number == 8)
{
    Console.Write("The passenger is dirty");
} else if (number == 3 || number == 9 || number == 12)
{
    Console.Write("The passenger is scratched");
}
else
{
    Console.Write("Passenger is fine");
}
