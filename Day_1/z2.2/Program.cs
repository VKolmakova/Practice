Console.Write("Enter three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int secondDigit = (number / 10) % 10;
int thitdDigit = (number / 1) % 10;
int answer = secondDigit * thitdDigit;
Console.Write($"{secondDigit} * {thitdDigit} = {answer}");

