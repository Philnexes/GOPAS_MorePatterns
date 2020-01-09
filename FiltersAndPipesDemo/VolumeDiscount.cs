namespace FiltersAndPipesDemo
{
    class VolumeDiscount : FilterBase
    {
        protected override bool IsForMe(Order order)
            => order.Price >= 1000000;

        protected override Order Transform(Order order)
        {
            order.Price -= 1000;
            return order;
        }
    }
}
