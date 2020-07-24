using FluentAssertions;
using NUnit.Framework;

namespace GenericBasics.Methods
{
    [TestFixture]
    public class SwapValuesTests
    {
        [Test]
        public void TestSwapWithInteger()
        {
            int first = 23;
            int second = 42;

            NonGenericClass.Swap(ref first, ref second);

            first.Should().Be(42);
            second.Should().Be(23);
        }

        [Test]
        public void TestSwapWithString()
        {
            string first = "Nancy";
            string second = "Judy";

            NonGenericClass.Swap(ref first, ref second);

            first.Should().Be("Judy");
            second.Should().Be("Nancy");
        }

        [Test]
        public void TestSwapWithObject()
        {
            object first = new object();
            object second = new object();

            object saveFirst = first;
            object saveSecond = second;

            NonGenericClass.Swap(ref first, ref second);

            first.Should().Be(saveSecond);
            second.Should().Be(saveFirst);
        }
    }
}