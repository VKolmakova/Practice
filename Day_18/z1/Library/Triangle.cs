namespace Library
{
    public class Triangle
    {
        private int a;
        public int A { get => this.a; set => this.a = value; }

        public int B { get; init; }
        public int C { get; init; }

        public Triangle(int a, int b, int c)
        {
            this.a = a;
            B = b;
            C = c;
        }

        public double Perimeter()
        {
            return a + B + C;
        }
        public double Square()
        {
            double p = 0.5 * (a + B + C);
            return Math.Sqrt(p * (p - a) * (p - B) * (p - C));
        }

        public TriangleType TypeTriangle()
        {
            if (a == B && B == C && B == C)
            {
                return TriangleType.Equilateral;
            }
            if (a == B || a == C || C == B)
            { return TriangleType.Isosceles; }

            return TriangleType.Scalene;
        }
    }
}