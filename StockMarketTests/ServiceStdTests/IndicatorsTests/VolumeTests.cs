using ModelStd;
using NUnit.Framework;
using ServiceStd.Indicators;
using System.Collections.Generic;

namespace StockMarketTests.ServiceStdTests.IndicatorsTests
{
    [TestFixture]
    class VolumeTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalculateAverageVolumeTest()
        {

            Volume volume = new Volume();
            List<PointData> points = new List<PointData>();
            points.Add(new PointData()
            {
                Volume = 0
            });

            points.Add(new PointData()
            {
                Volume = 1000
            });

            points.Add(new PointData()
            {
                Volume = 2000
            });
            int average= volume.CalculateAverageVolume(points, 3);

            Assert.AreEqual(1000,average);
        }

    }
}
