using System;
using System.Collections.Generic;
using System.Linq;

namespace BreakOutMethodObject
{
    public class OrderController
    {

        private readonly ShipmentCost shipmentCost = new ShipmentCost();

        public OrderController()
        {
            throw new SystemException("OrderController instantiation is too problematic");
        }

        public int TotalFor(List<OrderItem> orderItems)
        {
            int total = orderItems.Sum(orderItem => orderItem.Quantity*orderItem.Price);
            return total + shipmentCost.For(orderItems);
        }


    }
}
