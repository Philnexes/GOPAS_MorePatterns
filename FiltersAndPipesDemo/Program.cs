using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltersAndPipesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = DateTime.Now;

            //var p1 = new Pipe();
            //var p2 = new Pipe();
            //var p3 = new Pipe();

            //new PartnerDiscount()
            //{
            //    InPipe = p1,
            //    OutPipe = p2
            //};

            //new VolumeDiscount()
            //{
            //    InPipe = p2,
            //    OutPipe = p3
            //};

            //new PartnerDiscount()
            //{
            //    InPipe = p1,
            //    OutPipe = p2
            //};

            //new VolumeDiscount()
            //{
            //    InPipe = p2,
            //    OutPipe = p3
            //};

            //new PartnerDiscount()
            //{
            //    InPipe = p1,
            //    OutPipe = p2
            //};

            //new VolumeDiscount()
            //{
            //    InPipe = p2,
            //    OutPipe = p3
            //};

            var p = new Pipeline();
            p.AddFilter<PartnerDiscount>(3);
            p.AddFilter<VolumeDiscount>(3);


            var o1 = new Order() { Customer = "Gopas", Price = 2000000, Text = "slon" };
            var o2 = new Order() { Customer = "Jina", Price = 2000000, Text = "slon" };
            var o3 = new Order() { Customer = "Jina", Price = 200, Text = "krecek" };

            //p1.PutMessage(o1);
            //p1.PutMessage(o2);
            //p1.PutMessage(o3);

            p.InPipe.PutMessage(o1);
            p.InPipe.PutMessage(o2);
            p.InPipe.PutMessage(o3);

            while (true)
            {
                if (p.OutPipe.HasMessage) //p3.HasMesage)
                {
                    var o = p.OutPipe.GetMessage(); //p3.GetMessage();
                    Console.WriteLine($"{o.Customer} {o.Text} {o.Price} {DateTime.Now - start}");
                }

            }
        }
    }
}
