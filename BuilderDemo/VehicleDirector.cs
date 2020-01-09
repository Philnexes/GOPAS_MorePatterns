using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    class VehicleDirector
    {
        VehicleBuilder builder;

        public VehicleDirector(VehicleBuilder builder)
        {
            this.builder = builder;
        }

        public void BuildSportsCar()
        {
            for(int i = 0; i < 4; ++i)
            {
                builder.BuildWheel();

                if (i < 2)
                    builder.BuildDoor();
            }
        }

        public void BuildFamilyCar()
        {
            for (int i = 0; i < 4; ++i)
            {
                builder.BuildWheel();
                builder.BuildDoor();
            }
        }
    }
}
