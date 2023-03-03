namespace z1
{
    class program
    {
        enum JobTitle
        {
            Director = 150,
            Accountant = 100,
            Engineer = 15,
            Manager = 135
        }

        static string AskForBonus(JobTitle worker, int hours)
        {
            if ((int)worker < hours)
            {
                return "Calculate premium";
            }

            return "Do not pay premium";

        }


        static void Main()
        {
            Console.WriteLine("Select your position: \n1. Director \n2.Accountant \n3. Engineer \n4. Manager");
            int workNumber = int.Parse(Console.ReadLine());
            var workers = Enum.GetValues(typeof(JobTitle)).Cast<JobTitle>().ToList();
            var worker = workers[workNumber - 1];
            Console.WriteLine("Enter the number of working hours: ");
            int hours = int.Parse(Console.ReadLine());
            var message = AskForBonus(worker, hours);
            Console.WriteLine(message);
        }
    }
}