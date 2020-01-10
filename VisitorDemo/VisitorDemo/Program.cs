using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = new IntegerData();
            var d = new DoubleData();
            var inc = new IncVisitor();
            var dec = new DecVisitor();

            i.AcceptVisitor(inc);
            d.AcceptVisitor(dec);

            Console.WriteLine(i.Value);
            Console.WriteLine(d.Value);
        }
    }
}
