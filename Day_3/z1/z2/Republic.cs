using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    public class Republic : State

    {
        public Republic(string name, string ruler, int yearOfFoundation, string capital, string typeOfGoverment) : base(name, ruler, yearOfFoundation, capital, typeOfGoverment)
        {
        }
        public void CallReferendum()
        {
            Console.WriteLine("Referendum scheduled for February 27, 2022");
        }
    }
}
