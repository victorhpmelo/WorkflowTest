using Microsoft.EntityFrameworkCore;

namespace WorkflowTest.test
{
    public class AppDbContextTest
    {
        [Fact]
        public void CanInsertIntoDatabase()
        {
            var options = new DbContextOptionsBuilder<Data.AppDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            using (var context = new Data.AppDbContext(options))
            {
                // Arrange
                var person = new Models.Person { Name = "Victor Melo", BirthDate = DateTime.Parse("12/07/1998") };
                // Act
                context.People.Add(person);
                context.SaveChanges();
                // Assert
                var retrievedPerson = context.People.FirstOrDefault();
                Assert.NotNull(retrievedPerson);
                Assert.Equal(1, retrievedPerson.PersonId);
                Assert.Equal("Victor Melo", retrievedPerson.Name);
            }
        }
    }
}