using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new PartnerDiscount();
            head.Next = new VolumeDiscount();
            head.Next.Next = new NoDiscount();

            var o1 = new Order() { Customer = "Gopas", Price = 2000000, Text = "slon" };
            var o2 = new Order() { Customer = "Jina firma s.r.o.", Price = 2000000, Text = "slon" };
            var o3 = new Order() { Customer = "Jina firma s.r.o.", Price = 200, Text = "krecek" };

            head.Handle(o1);
            head.Handle(o2);
            head.Handle(o3);

            Console.WriteLine($"{o1.Customer} {o1.Text} {o1.Price}");
            Console.WriteLine($"{o2.Customer} {o2.Text} {o2.Price}");
            Console.WriteLine($"{o3.Customer} {o3.Text} {o3.Price}");

        }
    }
}
