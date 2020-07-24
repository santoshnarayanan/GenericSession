using System;
using FluentAssertions;
using NUnit.Framework;

namespace Introduction.Tests
{
    [TestFixture]
    public class SampleTests
    {
        private int _y;

        [SetUp]
        public void BeforeEachTest()
        {
            _y = 56;
        }

        [Test]
        public void CompareIntegerTest()
        {
            int x = 42;
            x.Should().Be(42);
        }

        [Test]
        public void CompareIntegerFieldTest()
        {
            _y.Should().Be(56);
        }

        [Test]
        public void CompareCollectionTest()
        {
            string[] names = { "John", "Cheryl", "Susie" };
            string[] othernames = { "Cheryl", "John", "Susie" };

            names.Should().NotBeEmpty().And.HaveCount(3);
            names.Should().BeEquivalentTo(othernames);
        }

        [Test]
        public void ThrowExceptionTest()
        {
            Action action = () =>
            {
                throw new Exception("Some exception");
            };

            action.Should().Throw<Exception>().WithMessage("Some Exception");
        }

    }
}