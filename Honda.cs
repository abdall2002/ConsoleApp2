using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedType
{
    class Honda : Vehicle, IDrivablle   // -> concrete type
    {
        public Honda(string brand, string model, int year) : base(brand, model, year)
        {

        }

        public void Move()
        {
            Console.WriteLine("Moving");
        }

        public void Stop()
        {
            Console.WriteLine("Stop");
        }
    }
}
