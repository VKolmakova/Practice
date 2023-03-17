using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Rectangle
    {
        public int a;
        public int A { get => this.a; set => this.a = value; }

        public int b;
        public int B { get => this.b; set => this.b = value; }

        public int c;
        public int C { get => this.c; set => this.c = value; }

        public int d;
        public int D { get => this.d; set => this.d = value; }

        public Rectangle(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }


        public double Perimeter()
        {
            return a + b + c + d;
        }
        public double Square()
        {
            return a * b;
        }

    }
}