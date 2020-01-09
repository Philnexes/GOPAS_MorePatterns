using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    class VehicleBuilder
    {
        public Vehicle Vehicle { get; private set; } = new Vehicle();

        public void BuildWheel()
        {
            Vehicle.Wheels.Add(new Wheel());
        }

        public void BuildDoor()
        {
            Vehicle.Doors.Add(new Door());
        }
    }
}
