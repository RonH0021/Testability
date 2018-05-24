namespace Testability
{
    class ShippingCalulator
    {
        public float CalulateShipping(Order order)
        {
            if (order.TotalPrice < 30f)
                return order.TotalPrice * 0.1f;

            return 0;
        }
    }
}