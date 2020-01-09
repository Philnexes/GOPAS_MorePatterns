using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDemo
{
    public abstract class Handler
    {
        public Handler Next { get; set; }
        public Order Handle(Order order)
        {
            if (IsForMe(order)) return DoHandle(order);
            else return Next.Handle(order);

            //pro kombinaci slev:
            //if (Next != null)
            //    if (IsForMe(order)) return Next.Handle(DoHandle(order));
            //    else  return Next.Handle(order);
            //else return order;
        }

        protected abstract Order DoHandle(Order order);

        protected abstract bool IsForMe(Order order);
    }
}
