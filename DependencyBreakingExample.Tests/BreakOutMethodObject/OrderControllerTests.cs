using System.Collections.Generic;
using BreakOutMethodObject;
using DependencyBreakingExamples.BreakOutMethodObject;
using NUnit.Framework;

namespace DependencyBreakingExample.Tests.BreakOutMethodObject
{
    [TestFixture]
    public class OrderControllerTest
    {
        [Test]
        public void TotalShouldBeZeroForEmptyOrder()
        {
            // given
            var orderController = new OrderController();

            // when
            var total = orderController.TotalFor(new List<OrderItem>(), new ShippingMethod());
            
            // then
            Assert.Equals(0, total);
        }
    }
}