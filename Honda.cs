using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedType
{
    class Honda : Vehicle   // -> concrete type
    {
        public Honda(string brand, string model, int year) : base(brand, model, year)
        {

        }
    }
}
