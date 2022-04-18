using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    class Engine
    {
        int horsePower;
        double cubicCapacity;
        public Engine(int horsePower, double cubicCapacity)
        {
            this.HorsePower = horsePower;
            this.CubicCapacity = cubicCapacity;
        }

        public int HorsePower { get { return horsePower; } set { horsePower = value; } }
        public double CubicCapacity { get { return cubicCapacity; } set { cubicCapacity = value; } }
    }
}
