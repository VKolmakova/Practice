using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace z2
{
    class Program
    {
        static void Main(string[] args)
        {
            string tmp2;
            string[] str;
            Console.WriteLine("Enter the number of elements in the first array:");
            int a = int.Parse(Console.ReadLine());
            str = new string[a];

            Console.WriteLine("Filling the first array");
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Enter "+i + " element in first array: ");
                str[i] = Console.ReadLine();
            }
            Massiv x = new Massiv(str, a);

            int b = 0;
            Console.WriteLine("Enter the number of elements in the second array:");
            b = int.Parse(Console.ReadLine());
            str = new string[b];
            Console.WriteLine("Filling the second array");
            for (int i = 0; i < b; i++)
            {
                Console.WriteLine("Enter "+i + " element in second array:");
                str[i] = Console.ReadLine();
            }
            Massiv y = new Massiv(str, b);

            Console.WriteLine("Want to output element 1 of the array? ");
            Console.WriteLine("1-yes");
            Console.WriteLine("0-no");
            int k = 0;
            k = int.Parse(Console.ReadLine());
            if (k != 0)
            {
                Console.WriteLine("Enter the array index of the element you want to display:");
                k = int.Parse(Console.ReadLine());
                tmp2 = x.getString(k);
                Console.WriteLine(tmp2);
            }

            Console.WriteLine("Want to change element 1 of the array? ");
            Console.WriteLine("1-yes");
            Console.WriteLine("0-no");
            k = 0;
            k = int.Parse(Console.ReadLine());
            if (k != 0)
            {
                Console.WriteLine("Changing the value of an element by index");
                Console.WriteLine("Enter index:");
                k = int.Parse(Console.ReadLine());
                Console.WriteLine("enter array element:");
                tmp2 = Console.ReadLine();
                x.setString(k, tmp2);
            }

            Console.WriteLine("Union of arrays");
            Massiv z = new Massiv(a + b);
            z = x - y;
            Console.WriteLine("New arrray: ");
            z.ClWrite();

            Console.ReadLine();

        }
    }
}