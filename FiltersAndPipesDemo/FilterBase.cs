using System;
using System.Timers;

namespace FiltersAndPipesDemo
{
    abstract class FilterBase
    {
        public Pipe InPipe { get; set; }
        public Pipe OutPipe { get; set; }

        Timer timer = new Timer(1000);

        public FilterBase()
        {
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if(InPipe != null && InPipe.HasMesage)
            {
                var order = InPipe.GetMessage();
                Order transfromed = order;
                if (IsForMe(order)) transfromed = Transform(order);
                OutPipe.PutMessage(transfromed);
            }
                
        }
        protected abstract bool IsForMe(Order order);
        protected abstract Order Transform(Order order);
    }
}
