using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedType
{
    abstract class Vehicle        // -> abstract type
    {
        protected string Brand;
        protected string Model;
        protected int Year;

        public Vehicle(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }
    }
}
