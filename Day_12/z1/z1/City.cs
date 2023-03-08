using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    internal class City : Locality
    {
        private int numberOfInhabitants;
        private int square;
        public City(string name, int numberOfInhabitants, int square) : base(name)
        {
            this.numberOfInhabitants = numberOfInhabitants;
            this.square = square;
        }

        public override int GetPopulationDensity() => numberOfInhabitants / square;
    }
}
