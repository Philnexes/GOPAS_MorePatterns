using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterDemo
{
    public class Difference : BinaryOperator
    {
        public Difference(IExpression left, IExpression right) : base(left, right)
        {
        }

        public override double Interpret(IDictionary<string, double> context)
            => left.Interpret(context) - right.Interpret(context);
    }
}
