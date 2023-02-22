int firstNumber, secondNumber, sum, difference, productОfNumbers;

Console.Write("Enter first number: ");
firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
secondNumber = Convert.ToInt32(Console.ReadLine());
sum = firstNumber + secondNumber;
difference = firstNumber - secondNumber;
productОfNumbers = firstNumber * secondNumber;

Console.WriteLine($" {firstNumber} + {secondNumber} = {firstNumber+secondNumber}");
Console.WriteLine($" {firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
Console.WriteLine($" {firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
