using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDemo
{
    class VolumeDiscount : Handler
    {
        protected override Order DoHandle(Order order)
        {
            order.Price -= 1000;
            return order;
        }

        protected override bool IsForMe(Order order)
            => order.Price >= 1000000;
    }
}
