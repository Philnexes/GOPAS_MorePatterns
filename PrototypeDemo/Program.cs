using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var prototype = new Class1();
            var i1 = (Class1)prototype.Clone();
            var i2 = (Class1)prototype.Clone();
            var i3 = prototype.Clone();

            Console.WriteLine(i1.Answer);
            Console.WriteLine(i2.Answer);
        }
    }
}
