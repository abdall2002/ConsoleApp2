using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedType
{
    class Caterpiller : Vehicle, ILoader
    {
        public Caterpiller(string brand, string model, int year) : base(brand, model, year)
        {
            
        }

        public void Load()
        {
            Console.WriteLine("Loading");    
        }

        public void UnLoad()
        {
            Console.WriteLine("UnLoading");
        }
    }
}
