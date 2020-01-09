using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterDemo
{
    public class Sum : BinaryOperator
    {
        public Sum(IExpression left, IExpression right) : base(left, right)
        {
        }

        public override double Interpret(IDictionary<string, double> context)
            => left.Interpret(context) + right.Interpret(context);
    }
}
