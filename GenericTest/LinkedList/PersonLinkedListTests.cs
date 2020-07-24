using FluentAssertions;
using Intoduction.Examples;
using NUnit.Framework;

namespace LinkedList.NonGeneric
{
    [TestFixture]
    public class PersonLinkedListTests
    {
        [Test]
        public void TestConstruction()
        {
            PersonLinkedList list = new PersonLinkedList();
            list.Count.Should().Be(0);
            list.Get(0).Should().BeNull();
        }

        [Test]
        public void TestOneMemberList()
        {
            PersonLinkedList list = new PersonLinkedList();
            list.Insert(new Person { FirstName = "John", LastName = "Jones" });

            list.Count.Should().Be(1);
            Person person = list.Get(0);
            person.Should().NotBeNull();
            person.FirstName.Should().Be("John");
            person.LastName.Should().Be("Jones");
        }

        [Test]
        public void TestGet()
        {
            PersonLinkedList list = new PersonLinkedList();
            list.Insert(new Person { FirstName = "John", LastName = "Jones" });
            list.Insert(new Person { FirstName = "Mary", LastName = "Sawyer" });
            list.Insert(new Person { FirstName = "Kathy", LastName = "Bates" });

            list.Count.Should().Be(3);

            Person person = list.Get(0);
            person.Should().NotBeNull();
            person.FirstName.Should().Be("Kathy");
            person.LastName.Should().Be("Bates");

            person = list.Get(1);
            person.Should().NotBeNull();
            person.FirstName.Should().Be("Mary");
            person.LastName.Should().Be("Sawyer");

            person = list.Get(2);
            person.Should().NotBeNull();
            person.FirstName.Should().Be("John");
            person.LastName.Should().Be("Jones");

            person = list.Get(3);
            person.Should().BeNull();
        }
    }
}