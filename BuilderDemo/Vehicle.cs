using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    class Vehicle
    {
        public List<Wheel> Wheels { get; private set; } = new List<Wheel>();
        public List<Door> Doors { get; private set; } = new List<Door>();
    }
}
