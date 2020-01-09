using System.Collections.ObjectModel;

namespace FiltersAndPipesDemo
{
    class Pipeline
    {
        public Pipe InPipe { get; private set; }
        public Pipe OutPipe { get; private set; }

        public Collection<FilterBase> pipes = new Collection<FilterBase>();

        public void AddFilter<T>(int count) where T: FilterBase, new()
        {
            var nextPipe = new Pipe();

            for(int i = 0; i < count; ++i)
            {
                pipes.Add(new T()
                {
                    InPipe = OutPipe,
                    OutPipe = nextPipe
                });
            }

            OutPipe = nextPipe;
        }
    }
}
