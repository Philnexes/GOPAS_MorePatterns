using System.ServiceModel;

namespace ServerDemo
{
    [ServiceContract]
    public interface ICalc
    {

        [OperationContract]
        double Plus(double x, double y);
    }



}
