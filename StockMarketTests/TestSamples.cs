using NUnit.Framework;

namespace StockMarketTests
{
    [TestFixture]
    public class TestSamples
    {
        //private Sample sample;

        [SetUp]
        public void MyTestInitialize()
        {
            //  sample = new Sample();
        }

        [Test]
        public void AddReturnsSumOfBothParams()
        {
            //int result = sample.Add(1, 1);
            //Assert.AreEqual(2, result);
            //Assert.AreNotEqual(10, result);

            //string nullResult = null;
            //Assert.IsNull(nullResult);

            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            //int actual = 5;
            //Assert.Contains(actual, numbers);
            // Assert.That(actual, Is.Not.EqualTo(50));
        }

        [TestCase(1, 1)]
        [TestCase(-1, -1)]
        [TestCase(-1, 1)]
        [TestCase(1, -1)]
        public void AddReturnsSumOfBotParams(int a, int b)
        {
            //int result = sample.Add(a, b);
            //int expected = a + b;

            //Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsTestingFunReturnTrue()
        {
            //bool result = sample.IsTestingFun();

            //Assert.IsTrue(result);
        }

        [Test]
        public void DivideByZeroThrowsException()
        {
            //Assert.Throws<DivideByZeroException>(delegate
            //{
            //    sample.Divide(2, 0);
            //});

            //Assert.That(delegate { sample.Divide(2, 0); }, Throws.Exception.TypeOf<DivideByZeroException>());

        }
    }
}

