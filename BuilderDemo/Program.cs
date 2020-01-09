using System;

namespace BuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new VehicleBuilder();
            var director = new VehicleDirector(builder);
            //director.BuildSportsCar();
            director.BuildFamilyCar();
            Console.WriteLine($"{builder.Vehicle.Wheels.Count} wheels; {builder.Vehicle.Doors.Count} doors");
        }
    }
}
