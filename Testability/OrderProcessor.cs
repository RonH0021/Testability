using System;

namespace Testability
{
    class OrderProcessor
    {
        private readonly ShippingCalulator _shippingCalulator;

        public OrderProcessor()
        {
            _shippingCalulator = new ShippingCalulator();
        }

        public void Process(Order order)
        {
            if (order.IsShipped)
                throw new InvalidOperationException("This order is already processed.");

            order.Shipment = new Shipment
            {
                Cost = _shippingCalulator.CalulateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }
}