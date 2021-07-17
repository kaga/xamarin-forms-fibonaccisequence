using fibonaccisequence.NumberGenerator;
using NUnit.Framework;

namespace test
{
    public class FibonacciSequenceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestInitialSequence()
        {
            var sequence = new FibonacciSequence();
            Assert.AreEqual(expected: 0, actual: sequence.Current);

            var sequence1 = sequence.NextSequence();
            Assert.AreEqual(expected: 1, actual: sequence1.Current);

            var sequence2 = sequence1.NextSequence();
            Assert.AreEqual(expected: 1, actual: sequence2.Current);

            var sequence3 = sequence2.NextSequence();
            Assert.AreEqual(expected: 2, actual: sequence3.Current);
        }
    }
}
