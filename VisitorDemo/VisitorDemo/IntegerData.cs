using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDemo
{
    public class IntegerData : IData
    {
        public int I { get; set; }
        public string Value => I.ToString();

        public void AcceptVisitor(IVisitor visitor)
        {
            visitor.VisitInteger(this);
        }
    }
}
