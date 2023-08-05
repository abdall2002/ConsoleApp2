using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedType
{
    enum Month
    {
        Jan,
        Feb,
        Mar,
        Apr,
        May,
        Jun,
        Jul,
        Aug,
        Sep,
        Oct,
        Nov,
        Dec
    }
    
    [Flags]     // 0 or 1
    enum Day
    {
        NONE           = 0b_0000_0000,  // 0
        MONDAY         = 0b_0000_0001,  // 1
        TUESDAY        = 0b_0000_0010,  // 2
        WEDNESDAY      = 0b_0000_0100,  // 4
        TURSDAY        = 0b_0001_1000,  // 8
        FRIDAY         = 0b_0001_0000,  // 16
        SATURDAY       = 0b_0010_0000,  // 32
        SUNDAY         = 0b_0100_0000,  // 64
        BUSDAY  = MONDAY | TUESDAY | WEDNESDAY | TURSDAY | FRIDAY, 
        WEEDEND = SATURDAY | SUNDAY    // 0b_0110_0000;

    }
 
}
