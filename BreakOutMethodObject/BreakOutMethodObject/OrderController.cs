using System;
using System.Collections.Generic;

namespace BreakOutMethodObject
{
    public class OrderController
    {
        private ShipmentCost ShipmentCost { get; set; }

        public OrderController()
        {
            throw new SystemException("OrderController instantiation is too problematic");
        }

        public int TotalFor(List<OrderItem> orderItems)
        {
            int total = 0;
            foreach (var orderItem in orderItems)
            {
                total += orderItem.Quantity * orderItem.Price;
            }
            int shipmentCost = ShipmentCost.For(orderItems);
            return total - shipmentCost;
        }


    }

    public class ShipmentCost
    {
        private int smallShipmentCost = 20;
        private int bigShipmentCost = 100;

        public int For(List<OrderItem> orderItems)
        {
            int totalSize = 0;
            foreach (var orderItem in orderItems)
            {
                totalSize += orderItem.Size;
            }
            if (totalSize < 50)
            {
                return smallShipmentCost;
            }
            return bigShipmentCost;
        }
    }
}
