using System.Collections.Generic;
using BreakOutMethodObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BreakOutMethodObjectTests
{
    [TestClass()]
    public class OrderControllerTest
    {
        [TestMethod()]
        public void TotalShouldBeZeroForEmptyOrder()
        {
            // given
            var orderController = new OrderController();

            // when
            var total = orderController.TotalFor(new List<OrderItem>());
            
            // then
            Assert.Equals(0, total);
        }
    }
}