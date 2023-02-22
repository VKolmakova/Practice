int number, result;
Console.Write("Enter a four-digit number: ");
number = Convert.ToInt32(Console.ReadLine());
result = (number % 100)*100 + number / 100;
Console.WriteLine(result);

