using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    public class Monarchy : State
    {
        public Monarchy(string name, string ruler, int yearOfFoundation, string capital, string typeOfGoverment) : base(name, ruler, yearOfFoundation, capital, typeOfGoverment)
        {
        }
        public void TitleTransfer()
        {
            Console.WriteLine("In 2022, Elizabeth II transferred the title to Charles III");
        }

    }
}
