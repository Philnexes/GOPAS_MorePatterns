using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterDemo
{
    public class Literal : IExpression
    {
        double value;

        public Literal(double value)
        {
            this.value = value;
        }

        public double Interpret(IDictionary<string, double> context)
            => value;
    }
}
