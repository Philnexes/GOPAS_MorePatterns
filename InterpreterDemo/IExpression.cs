using System.Collections.Generic;

namespace InterpreterDemo
{
    public interface IExpression
    {
        double Interpret(IDictionary<string, double> context);
    }
}
