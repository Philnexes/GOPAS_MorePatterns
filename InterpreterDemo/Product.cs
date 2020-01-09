using System.Collections.Generic;

namespace InterpreterDemo
{
    public class Product : BinaryOperator
    {
        public Product(IExpression left, IExpression right) : base(left, right)
        {
        }

        public override double Interpret(IDictionary<string, double> context)
            => left.Interpret(context) * right.Interpret(context);
    }
}
