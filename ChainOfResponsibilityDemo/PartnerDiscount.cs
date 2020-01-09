using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDemo
{
    class PartnerDiscount : Handler
    {
        protected override Order DoHandle(Order order)
        {
            order.Price *= .9;
            return order;
        }

        protected override bool IsForMe(Order order)
            => order.Customer == "Gopas";
    }
}
