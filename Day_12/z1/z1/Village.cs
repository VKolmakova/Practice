using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    internal class Village : Locality
    {
        private int numberOfHouses;
        private int numberOfPeopleInHouse;
        private int square;
        public Village(string name, int numberOfHouses, int numberOfPeopleInHouse, int square) : base(name)
        {
            this.numberOfHouses = numberOfHouses;
            this.numberOfPeopleInHouse = numberOfPeopleInHouse;
            this.square = square;
        }
        public override int GetPopulationDensity() => (numberOfPeopleInHouse * numberOfHouses) / square;
    }
}
