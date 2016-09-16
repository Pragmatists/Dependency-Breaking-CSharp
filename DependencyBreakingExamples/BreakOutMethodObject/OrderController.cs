using System;
using System.Collections.Generic;
using System.Linq;
using BreakOutMethodObject;

namespace DependencyBreakingExamples.BreakOutMethodObject
{
    public class OrderController
    {
        private readonly PriceList priceList = new PriceList();
        private readonly ShipmentCost shipmentCost = new ShipmentCost();
        private readonly TaxCalculator tax = new TaxCalculator();
        private readonly EmailSender emailSender = new EmailSender();
        public OrderController()
        {
            throw new SystemException("OrderController instantiation is too problematic");
        }

        public int TotalFor(List<OrderItem> orderItems, ShippingMethod method)
        {
            var total = orderItems.Sum(orderItem => orderItem.Quantity*priceList.PriceFor(orderItem));
            var price = total + shipmentCost.For(orderItems, method);
            return price + tax.CalculateFor(price);
        }

        public void ApproveOrder(List<OrderItem> orderItems, ShippingMethod shippingMethod)
        {
            emailSender.SendOrderConfirmation();
        }
    }
    
    public class EmailSender
    {
        public void SendOrderConfirmation()
        {
            // ...
        }
    }

    public class ShippingMethod
    {
    }

    internal class TaxCalculator
    {
        public int CalculateFor(int price)
        {
            return (int) (0.4*price);
        }
    }

    public class PriceList
    {
        public int PriceFor(OrderItem orderItem)
        {
            return 1;
        }
    }
}