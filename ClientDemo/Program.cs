using System;

namespace ClientDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var brokerProxy = new Brokers.BrokerClient();
            var address = brokerProxy.GetAddress("Calc");
            var clientProxy = new Server.CalcClient("BasicHttpBinding_ICalc", address);
            Console.WriteLine(clientProxy.Plus(1, 2));
        }
    }
}
