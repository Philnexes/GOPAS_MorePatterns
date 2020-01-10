using System;

namespace DecoratorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calc();
            var loggingCalc = new LoggingCalcDecorator(calc);
            loggingCalc.Plus(1.111111);
            loggingCalc.Plus(2.111111);
            Console.WriteLine(loggingCalc.Result);
            var roundingDecorator = new RoundingCalcDecorator(loggingCalc);
            roundingDecorator.Plus(1.111111);
            roundingDecorator.Plus(2.111111);
            Console.WriteLine(roundingDecorator.Result);
        }
    }
}
