using FluentAssertions;
using NUnit.Framework;

namespace GenericBasics.Classes {
   public class Book {
      public string Title { get; set; }
      public string Author { get; set; }
   }

   [TestFixture]
   public class BookRepositoryTests {
      [Test]
      public void TestAddBook() {
         Repository<Book> repository = new Repository<Book>();
         repository.Add( new Book {Title = "Winesburg Ohio", Author = "Sherwood Anderson"} );
         repository.All().Should().NotBeEmpty().And.HaveCount( 1 );
      }

      [Test]
      public void TestGetBookByIndex() {
         Repository<Book> repository = new Repository<Book>();
         repository.Add( new Book { Title = "Winesburg Ohio", Author = "Sherwood Anderson" } );

         Book first = repository.Get( 0 );
         first.Should().NotBeNull();
         first.Title.Should().Be( "Winesburg Ohio" );
         first.Author.Should().Be( "Sherwood Anderson" );
      }

      [Test]
      public void TestDeleteBook() {
         Repository<Book> repository = new Repository<Book>();
         Book book = new Book { Title = "Winesburg Ohio", Author = "Sherwood Anderson" };
         repository.Add( book );
         repository.All().Should().NotBeEmpty().And.HaveCount( 1 );

         repository.Remove( book );
         repository.All().Should().BeEmpty();
      }
   }
}