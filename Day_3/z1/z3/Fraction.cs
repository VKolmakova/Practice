using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3
{
    class Fraction
    {
        public int firstNumerator;
        public int firstDenominator;
        public int secondNumerator;
        public int secondDenominator;

        public Fraction(int firstNumerator, int firstDenominator, int secondNumeration, int secondDenominator)
        {
            this.firstNumerator = firstNumerator; //Numerator - числитель
            this.firstDenominator = firstDenominator; // Denominator - знаменатель
            this.secondNumerator = secondNumeration;
            this.secondDenominator = secondDenominator;
        }
        public void Multiply()
        {
            int numenator = (firstNumerator * secondNumerator);
            int denominator = (firstDenominator * secondDenominator);
            Console.WriteLine($"Numltiply = {numenator} / {denominator}");
        }
        public void Division()
        {
            int numenator = (firstNumerator * secondDenominator);
            int denominator = (firstDenominator * secondNumerator);
            Console.WriteLine($"Division = {numenator} / {denominator}");
        }
        public void Sum()
        {
            int commonDenominator = CommonDenominator(firstDenominator, secondDenominator);
            int firstFinalNumerator = (commonDenominator / firstDenominator) * firstNumerator;
            int secondFinalNumerator = (commonDenominator / secondDenominator) * secondNumerator;
            Console.WriteLine($"Sum = {firstFinalNumerator + secondFinalNumerator} / {commonDenominator}");
        }
        public void Subtraction()
        {
            int commonDenominator = CommonDenominator(firstDenominator, secondDenominator);
            int firstFinalNumerator = (commonDenominator / firstDenominator) * firstNumerator;
            int secondFinalNumerator = (commonDenominator / secondDenominator) * secondNumerator;
            Console.WriteLine($"Subtraction = {firstFinalNumerator - secondFinalNumerator} / {commonDenominator}");
        }
        private int CommonDenominator(int firstDenominator, int secondDenominator)
        {
            for (int i = firstDenominator; i < secondDenominator * firstDenominator; i += firstDenominator)
            {
                if (i % firstDenominator == 0 && i % secondDenominator == 0) return i;
            }

            return -1;
        }

    }
}
