using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    class A
    {
        public int a;
        public int b;
        public A(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public double GetArithmeticMean() => 1 / Math.Pow(a, 2);
        public double CubSumOfNumbers() => Math.Pow((a + b), 3);

    }
}
