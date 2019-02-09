using NUnit.Framework;
using RepositoryStd.Database;
using ServiceStd;
using ServiceStd.AI;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarketTests.ServiceStdTests.AITests
{
    [TestFixture]
    class AccordHelloWorldTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void XORTest()
        {
            AccordHelloWorld accordHelloWorld = new AccordHelloWorld();
            accordHelloWorld.XOR();
            Assert.True(true);

        }

        [Test]
        public void LinearRegressionTest()
        {
            AccordHelloWorld accordHelloWorld = new AccordHelloWorld();
            accordHelloWorld.LinearRegression();
            Assert.True(true);

        }
    }
}
