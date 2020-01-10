namespace VisitorDemo
{
    public interface IVisitor
    {
        void VisitInteger(IntegerData data);
        void VisitDouble(DoubleData data);
    }
}