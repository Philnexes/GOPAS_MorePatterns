using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersAndPipesDemo
{
    class PartnerDiscount : FilterBase
    {
        protected override bool IsForMe(Order order)
            => order.Customer == "Gopas";

        protected override Order Transform(Order order)
        {
            order.Price *= .9;
            return order;
        }
    }
}
