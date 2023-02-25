using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    public class Kingdom : State
    {
        public Kingdom(string name, string ruler, int yearOfFoundation, string capital, string typeOfGoverment) : base(name, ruler, yearOfFoundation, capital, typeOfGoverment)
        {
        }
        public void TitleTransfer()
        {
            Console.WriteLine("Margrethe II is reigning queen of Denmark from the Glücksburg dynasty since 14 January 1972, after the death of her father King Frederick IX");
        }
    }
}
