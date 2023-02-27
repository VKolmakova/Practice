class Program
{
    static void F(int number)
    {
        
        int firstDigit = (number / 100) % 10;
        int secondDigit = (number / 10) % 10;
        int thirdDigit = (number / 1) % 10;
        int[] array = new int[3];
        array[0] = thirdDigit;
        array[1] = secondDigit;
        array[2] = firstDigit;
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
        }
    }
    static void Main()
    {

        Console.Write("Enter three-digit number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        F(number);
    }
}