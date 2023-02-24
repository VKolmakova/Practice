Console.Write("Enter passenger number from 1 to 12: ");
int number = Convert.ToInt32(Console.ReadLine());
switch (number)
{
    case (4):
        Console.Write("The passenger is dirty");
        break;
    case (5):
        Console.Write("The passenger is dirty");
        break;
    case (6):
        Console.Write("The passenger is dirty");
        break;
    case (7):
        Console.Write("The passenger is dirty");
        break;
    case (3):
        Console.Write("The passenger is scratched");
        break;
    case (9):
        Console.Write("The passenger is scratched");
        break ;
        case (12):
        Console.Write("The passenger is scratched");
        break;
    default:
        Console.Write("Passenger is fine");
        break;
}