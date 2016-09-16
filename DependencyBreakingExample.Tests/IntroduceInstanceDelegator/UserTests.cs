using System;
using DependencyBreakingExamples.IntroduceInstanceDelegator;
using NUnit.Framework;

namespace DependencyBreakingExample.Tests.IntroduceInstanceDelegator
{
    [TestFixture]
    public class UserTests
    {
        [Test]
        public void ShouldDeactivateUser()
        {
            // given
            User user = new User();

            // when
            user.Deactivate();

            // then
            Assert.IsFalse(user.Active);
        }

        [Test]
        public void ShouldHaveCorrectDeactivationTimeAfterBeingDeactivated()
        {
            // given
            User user = new User();

            // when
            user.Deactivate();

            // then
            DateTime? howToSetCorrectExpectedValue = null;
            Assert.AreEqual(howToSetCorrectExpectedValue, user.DeactivatedAt);
        }
    }
}