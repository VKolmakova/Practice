class Program
{/// <summary>
 /// Метод F , находящий число
 ///</summary>
    static void F(int number)
    {

        int firstDigit = (number / 100) % 10;
        int secondDigit = (number / 10) % 10;
        int thirdDigit = (number / 1) % 10;
        int[] array = new int[3];
        array[0] = thirdDigit;
        array[1] = secondDigit;
        array[2] = firstDigit;
        ///<summary>
        ///Цикл For, начинающийся с 0 и заканчивающийся при i равном длинне массива,
        ///выполняющий инкримент на единицу после каждой интерации цикла, производит вывод на экран элемент массива
        /// </summary>
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
        }
    }
    ///<summary>
    ///Метод Main точка входа.
    /// </summary>
    static void Main()
    {
        ///<summary>
        ///Инициализация переменной 
        /// </summary>
        Console.Write("Enter three-digit number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        ///<summary>
        ///Вызов метода F
        /// </summary>
        F(number);
    }
}