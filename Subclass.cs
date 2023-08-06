using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedType
{
    public delegate bool Filter(int n);
    class Subclass : Baseclass
    {
        public Subclass(int scvalue) : base(scvalue)
        {
             
        }
    }
}
