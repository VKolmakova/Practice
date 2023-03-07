using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    public class B : A
    {
        private double _d { get; set; }
        public B(double d, double a, double b) : base(a, b)
        {
            _d = d;
        }
        public B(double d)
        {
            _d = d;
        }
        public double c2
        {
            get
            {
                for (int i = 0; i < 4; i++)
                {
                    _a = _a + _b + _d;
                }
                return _a;
            }

        }
    }
}
