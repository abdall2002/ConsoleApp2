using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedType
{
    class Eagle : Animal
    {
        public void Fly()
        {
            Console.WriteLine("Flying");
        }

        public override void Move()
        {
            base.Move();
            Console.WriteLine("The Eagle");
        }
    }
}
