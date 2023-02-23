Console.Write("Enter three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int firstDigit = (number / 100) % 10;
int thirdDigit = (number / 1) % 10;
if (firstDigit > thirdDigit)
{
    Console.WriteLine("The first digit is greater than the last");
}else if (firstDigit < thirdDigit)
{
    Console.WriteLine("The first digit is less than the last");
}else
{
    Console.WriteLine("The digits are equal");
}