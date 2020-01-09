using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterDemo
{
    public abstract class BinaryOperator : IExpression
    {
        protected IExpression left;
        protected IExpression right;

        protected BinaryOperator(IExpression left, IExpression right)
        {
            this.left = left;
            this.right = right;
        }

        public abstract double Interpret(IDictionary<string, double> context);
        
    }
}
