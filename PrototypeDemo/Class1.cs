using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDemo
{
    class Class1 : ICloneable
    {
        public int Answer { get; private set; }
        
        public Class1()
        {
            Console.WriteLine("Dlooooooooooooooouha inicializace");
            Answer = 42;
        }

        public object Clone() => MemberwiseClone();
    }
}
