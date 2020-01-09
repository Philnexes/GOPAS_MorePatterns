using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var expression = new Difference(
                new Sum(
                    new Product(
                        new Literal(2),
                        new Variable("x")),
                    new Variable("y")),
                new Variable("z"));

            Console.WriteLine(expression.Interpret(
                new Dictionary<string, double>() {
                    { "x", 2 },
                    { "y", 3 },
                    { "z", 4 }
                }));
        }
    }
}
