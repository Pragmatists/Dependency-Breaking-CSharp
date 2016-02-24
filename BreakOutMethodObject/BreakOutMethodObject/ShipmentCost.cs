using System.Collections.Generic;
using System.Linq;

namespace BreakOutMethodObject
{
    public class ShipmentCost
    {
        private readonly int smallShipmentCost = 20;
        private readonly int bigShipmentCost = 100;

        public int For(List<OrderItem> orderItems)
        {
            int totalSize = orderItems.Sum(orderItem => orderItem.Size);
            if (totalSize < 50)
            {
                return smallShipmentCost;
            }
            return bigShipmentCost;
        }
    }
}