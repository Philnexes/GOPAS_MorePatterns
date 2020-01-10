using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServerDemo
{   public class Calc : ICalc
    {
        public double Plus(double x, double y) => x + y;
    }
}
