using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDemo
{
    public class DoubleData: IData
    {
        public double D { get; set; }

        public string Value => D.ToString();

        public void AcceptVisitor(IVisitor visitor)
        {
            visitor.VisitDouble(this);
        }
    }
}
