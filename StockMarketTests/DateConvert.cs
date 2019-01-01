using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System;
using System.Globalization;

namespace StockMarketTests
{
    [TestFixture]

   
    class DateConvert
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DateConvertTest()
        {
            string date = "20121004";

            string result = DateTime.ParseExact(date, "yyyyMMdd",
                            CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
            StringAssert.AreEqualIgnoringCase("2012-10-04", result);

        }

    }
}
