namespace DecoratorDemo
{
    class Calc : ICalc
    {
        public double Result { get; set; }
        public void Plus(double x) => Result += x;
    }
}
