using System;
using IntroduceInstanceDelegator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntroduceInstanceDelegatorTests
{
    [TestClass()]
    public class UserTests
    {

        [TestMethod()]
        public void ShouldDeactivateUser()
        {
            // given
            User user = new User();

            // when
            user.Deactivate();

            // then
            Assert.IsFalse(user.Active);

        }

        [TestMethod()]
        public void ShouldHaveCorrectDeactivationTimeAfterBeingDeactivated()
        {
            // given
            User user = new User();

            // when
            user.Deactivate();

            // then
            Assert.Fail("How do I test it?");
        }

    }
}