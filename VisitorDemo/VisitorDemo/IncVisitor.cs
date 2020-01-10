using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDemo
{
    class IncVisitor : IVisitor
    {
        public void VisitDouble(DoubleData data)
        {
            data.D += .1;
        }

        public void VisitInteger(IntegerData data)
        {
            data.I += 1;
        }
    }
}
