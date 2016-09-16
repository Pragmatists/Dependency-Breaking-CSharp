using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyBreakingExamples.ParameterizeConstructor;
using NUnit.Framework;

namespace DependencyBreakingExample.Tests.ParameterizeConstructor
{
    class AuthenticationServiceTest
    {
        [Test]
        public void A()
        {
            new AuthenticationService();
        }
    }
}
