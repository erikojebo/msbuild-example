using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace MsbuildExample.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Add_returns_the_sum_of_the_parameters()
        {
            Assert.AreEqual(3, Calculator.Add(1,2));
        }
    }
}
