using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace z1
{
    internal abstract class Locality
    {
        private string name;
        public string Name { get => name; }
        public Locality(string name)
        {
            this.name = name;
        }
        public virtual int GetPopulationDensity() => 5;
        public static double GetMinPopulationDensity(Locality[] localities)
        {
            if (localities != null)
            {
                int min = localities[0].GetPopulationDensity();
                for (int i = 0; i < localities.Length; i++)
                {
                    if (min > localities[i].GetPopulationDensity())
                    {
                        min = localities[i].GetPopulationDensity();

                    }
                }
                return min;
            }
            throw new Exception("Array is null");
        }
    }
}

