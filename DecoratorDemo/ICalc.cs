namespace DecoratorDemo
{
    interface ICalc
    {
        double Result { get; set; }

        void Plus(double x);
    }
}