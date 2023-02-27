using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace z5
{
    internal class Product
    {
        private string name;
        private string nameOfStore;
        private double price;

        public Product(string name, string nameOfStore, double price)
        {
            this.name = name;
            this.nameOfStore = nameOfStore;
            this.price = price;
        }
        public string getName()
        {
            return name;
        }
        public string getNameOfStore()
        {
            return nameOfStore;
        }
        public double getPrice()
        {
            return price;
        }

    }

}