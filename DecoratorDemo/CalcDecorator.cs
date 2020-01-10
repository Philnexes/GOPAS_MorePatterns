namespace DecoratorDemo
{
    abstract class CalcDecorator : ICalc
    {
        ICalc calc;

        protected CalcDecorator(ICalc calc)
        {
            this.calc = calc;
        }

        public double Result
        {
            get => calc.Result;
            set => calc.Result = value;
        }

        public void Plus(double x)
        {
            PrePlus(x);
            calc.Plus(x);
            PostPlus(x);
        }

        protected abstract void PrePlus(double x);
        protected abstract void PostPlus(double x);
    }
}
