using FluentAssertions;
using GenericBasics.Classes;
using NUnit.Framework;

namespace GenericBasics.Interfaces
    {
        public class Books
        {
            public string Title { get; set; }
            public string Author { get; set; }
        }

        [TestFixture]
        public class BookNewRepositoryTests
        {
            [Test]
            public void TestAddBook()
            {
                IRepository<Books> repository = new RepositoryN<Books>();
                repository.Add(new Books { Title = "Winesburg Ohio", Author = "Sherwood Anderson" });
                repository.All().Should().NotBeEmpty().And.HaveCount(1);
            }

            [Test]
            public void TestGetBookByIndex()
            {
                IRepository<Books> repository = new RepositoryN<Books>();
                repository.Add(new Books { Title = "Winesburg Ohio", Author = "Sherwood Anderson" });

                Books first = repository.Get(0);
                first.Should().NotBeNull();
                first.Title.Should().Be("Winesburg Ohio");
                first.Author.Should().Be("Sherwood Anderson");
            }

            [Test]
            public void TestDeleteBook()
            {
                IRepository<Books> repository = new RepositoryN<Books>();
                Books book = new Books { Title = "Winesburg Ohio", Author = "Sherwood Anderson" };
                repository.Add(book);
                repository.All().Should().NotBeEmpty().And.HaveCount(1);

                repository.Remove(book);
                repository.All().Should().BeEmpty();
            }
        }
    }

