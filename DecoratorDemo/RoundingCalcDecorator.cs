using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDemo
{
    class RoundingCalcDecorator : CalcDecorator
    {
        public RoundingCalcDecorator(ICalc calc) : base(calc)
        {
        }

        protected override void PostPlus(double x)
        {
            Result = Math.Round(Result, 4);
        }

        protected override void PrePlus(double x)
        {
            
        }
    }
}
