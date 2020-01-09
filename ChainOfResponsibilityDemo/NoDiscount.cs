using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDemo
{
    class NoDiscount : Handler
    {
        protected override Order DoHandle(Order order) => order;

        protected override bool IsForMe(Order order) => true;
    }
}
