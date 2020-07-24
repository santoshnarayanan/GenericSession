using FluentAssertions;
using NUnit.Framework;

namespace GenericBasics.Classes {
   public class Person {
      public string FirstName { get; set; }
      public string LastName { get; set; }
   }

   [TestFixture]
   public class PersonRepositoryTests {
      [Test]
      public void TestAddPerson() {
         Repository<Person> repository = new Repository<Person>();
         repository.Add( new Person {FirstName = "John", LastName = "Smith"} );
         repository.All().Should().NotBeEmpty().And.HaveCount( 1 );
      }

      [Test]
      public void TestGetPersonByIndex() {
         Repository<Person> repository = new Repository<Person>();
         repository.Add( new Person { FirstName = "John", LastName = "Smith" } );

         Person first = repository.Get( 0 );
         first.Should().NotBeNull();
         first.FirstName.Should().Be( "John" );
         first.LastName.Should().Be( "Smith" );
      }

      [Test]
      public void TestDeletePerson() {
         Repository<Person> repository = new Repository<Person>();
         Person person = new Person {FirstName = "John", LastName = "Smith"};
         repository.Add( person );
         repository.All().Should().NotBeEmpty().And.HaveCount( 1 );

         repository.Remove( person );
         repository.All().Should().BeEmpty();
      }
   }
}