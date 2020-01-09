using System.Collections.Concurrent;

namespace FiltersAndPipesDemo
{
    class Pipe
    {
        ConcurrentQueue<Order> queue = new ConcurrentQueue<Order>();
        public bool HasMesage => !queue.IsEmpty;

        public bool HasMessage { get; internal set; }

        public Order GetMessage() {
            if (queue.TryDequeue(out Order order)) return order;
            else throw new System.Exception("Can't dequeue");
        }

        public void PutMessage(Order order) => queue.Enqueue(order);
    }
}
