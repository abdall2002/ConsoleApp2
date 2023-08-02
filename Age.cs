using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedType
{
    readonly struct Age
    {
        //public int years;                    // -> must br all contains readonly;
        public readonly int years;
        public readonly int Whatever; 
        
        // Constructor;
        public Age(int years, int whatever)
        {
            this.years = years;
            this.Whatever = whatever;
        }
    }
}
