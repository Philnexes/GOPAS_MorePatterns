using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDemo
{
    class LoggingCalcDecorator : CalcDecorator
    {
        double originalResult;

        public LoggingCalcDecorator(ICalc calc) : base(calc)
        {
        }

        protected override void PostPlus(double x)
        {
            Console.WriteLine($"{originalResult}+{x}={Result}");
        }

        protected override void PrePlus(double x)
        {
            originalResult = Result;
        }
    }
}
