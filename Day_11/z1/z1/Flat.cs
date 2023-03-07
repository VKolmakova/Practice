using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    class Flat
    {
        private string name;
        private double costPerSquareMeter;
        private double square;

        public string Name { get => name; set => name = value; }
        public double CostPerSquareMeter { get => costPerSquareMeter; set => costPerSquareMeter = value; }
        public double Square { get => square; set => square = value; }

        public Flat(string name, double cost, double square)
        {
            Name = name;
            CostPerSquareMeter = cost;
            Square = square;
        }

        public virtual string[] WritePars() => new[] { Name, CostPerSquareMeter.ToString(), Square.ToString() };
        public virtual double GetApartmentCost() => CostPerSquareMeter * Square;
    }

}
