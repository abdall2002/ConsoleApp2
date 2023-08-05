using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedType
{
    class Caterpiller : Vehicle, ILoader, IDrivablle
    {
        public Caterpiller(string brand, string model, int year) : base(brand, model, year)
        {
            
        }

        public void Load()
        {
            Console.WriteLine("Loading");    
        }

        public void Move()
        {
            Console.WriteLine("Moving");
        }

        public void Stop()
        {
            throw new NotImplementedException("Stop");
        }

        public void UnLoad()
        {
            Console.WriteLine("UnLoading");
        }
    }
}
