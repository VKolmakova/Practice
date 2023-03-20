Console.Write("Enter three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
Task<int> task1 = new Task<int>(() => ProductOfSecondAndThirdDigits(number));
Task task2 = task1.ContinueWith(task => Print(task.Result));
task1.Start();
task2.Wait();
static int ProductOfSecondAndThirdDigits(int number)
    {
    int secondDigit = (number / 10) % 10;
    int thitdDigit = (number / 1) % 10;
    int answer = secondDigit * thitdDigit;
    Console.Write($"{secondDigit} * {thitdDigit} = {answer}");
    return answer;

}
static void Print(int mulNumber)
{
    Console.WriteLine($"\nAnswer: {mulNumber}");
}