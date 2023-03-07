
namespace z1
{
    class Program
    {
        static string[] pars = new string[4];
        static List<Flat> ap1 = new List<Flat>();
        static List<FlatInTheCenter> ap2 = new List<FlatInTheCenter>();
        static void Main(string[] args)
        {
            char temp;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose an action");
                Console.WriteLine("1 Create object of class Apartment");
                Console.WriteLine("2 Create object of class Apartment in the center");
                Console.WriteLine("3 Display all object fields");
                Console.WriteLine("4 Display the cost of apartments");
                Console.WriteLine("0 Exit");

                temp = Console.ReadLine()[0];
                switch (temp)
                {
                    case '1':
                        First();
                        break;
                    case '2':
                        Second();
                        break;
                    case '3':
                        GetAllPars();
                        break;
                    case '4':
                        GetCosts();
                        break;
                    case '0':
                        Environment.Exit(1);
                        break;
                    default:
                        break;
                }
            }
        }

        static void First()
        {
            Console.Clear();
            Console.WriteLine("Creating an object of class Apartment");
            Console.Write("Name: ");
            pars[0] = Console.ReadLine();
            Console.Write("The cost of 1 sq. meters: ");
            pars[1] = Console.ReadLine().Replace('.', ',');
            Console.Write("Square: ");
            pars[2] = Console.ReadLine().Replace('.', ',');
            ap1.Add(new Flat(pars[0], double.Parse(pars[1]), double.Parse(pars[2])));
            Console.Clear();
            Console.WriteLine("Successfully!");
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
        }

        static void Second()
        {
            Console.Clear();
            Console.WriteLine("Creating an object of class Apartment in the center");
            Console.Write("District name: ");
            pars[0] = Console.ReadLine(); ;
            Console.Write("Apartment name: ");
            pars[1] = Console.ReadLine();
            Console.Write("The cost of 1 sq. meters: ");
            pars[2] = Console.ReadLine().Replace('.', ',');
            Console.Write("Square: ");
            pars[3] = Console.ReadLine().Replace('.', ',');
            ap2.Add(new FlatInTheCenter(pars[0], pars[1], double.Parse(pars[2]), double.Parse(pars[3])));
            Console.Clear();
            Console.WriteLine("Successfully!");
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
        }

        static void GetAllPars()
        {
            Console.Clear();
            Console.WriteLine("Object fields");
            Console.WriteLine("Apartments:");
            foreach (var x in ap1)
            {
                Console.WriteLine("{0}:", x.Name);
                Console.WriteLine("The cost of 1 sq. meters: {0}", x.CostPerSquareMeter);
                Console.WriteLine("Square: {0}", x.Square);
            }
            Console.WriteLine("Apartments in the center:");
            foreach (var x in ap2)
            {
                Console.WriteLine("{0}:", x.Name);
                Console.WriteLine("District: {0}", x.DistrictName);
                Console.WriteLine("The cost of 1 sq. meters: {0}", x.CostPerSquareMeter);
                Console.WriteLine("Square: {0}", x.Square);
            }
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
        }

        static void GetCosts()
        {
            Console.Clear();
            Console.WriteLine("Apartment prices");
            Console.WriteLine("Apartments:");
            foreach (var x in ap1)
            {
                Console.WriteLine("{0}: {1}", x.Name, x.GetApartmentCost());
            }
            Console.WriteLine("Apartments in the center:");
            foreach (var x in ap2)
            {
                Console.WriteLine("{0}: {1}", x.Name, x.GetApartmentCost());
            }
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
        }
    }
    
}
