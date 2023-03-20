using System.Threading.Tasks;

void ModifiedNumber(int number)
{

    double result = (number % 100) * 100 + number / 100;
    Console.WriteLine(result);

}
Console.Write("Enter a four-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
var task = Task<int>.Run(() => ModifiedNumber(number));
Thread.Sleep(1000);

Task task1 = new Task(() => ModifiedNumber(number));
task1.Start();
Thread.Sleep(1000);

Task task2 = Task.Factory.StartNew(() => ModifiedNumber(number));
Thread.Sleep(1000);
while (!task1.IsCompleted)
{
    Thread.Sleep(2000);
    Console.WriteLine("Wait...");
    Console.Clear();
}