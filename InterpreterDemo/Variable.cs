using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterDemo
{
    public class Variable : IExpression
    {
        string name;

        public Variable(string name)
        {
            this.name = name;
        }

        public double Interpret(IDictionary<string, double> context)
            => context[name];
    }
}
