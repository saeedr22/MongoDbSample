
using MongoDB.Driver;

namespace Services
{
    public class Insert
    {
        public async void InsertOneAsync()
        {
            var book = new Book()
            {
                Title = "Gone With Wind",
                ISBN = "43442424",
                Price = 50000,
                LastStock = new DateTime(),
                Language = new Language()
                {
                    Name = "Persian"
                },
                Authors = new List<Author>()
               {
                   new Author()
                   {
                       Name = "Margaret Mitchell"
                   },
                     new Author()
                   {
                       Name = "Test (Translator)"
                   },
               }
            };

            // string connectionString = "mongodb://localhost:27017";
            // MongoClientSettings settings = MongoClientSettings.FromUrl(new MongoUrl(connectionString));
            //var client = new MongoClient(settings);
            var client = new MongoClient();
            var db = client.GetDatabase("publisher");
            var collection = db.GetCollection<Book>("books");

            await collection.InsertOneAsync(book);
        }


        public async void InsertManyAsync()
        {
            var book = new Book()
            {
                Title = "Gone With Wind",
                ISBN = "43442424",
                Price = 50000,
                LastStock = new DateTime(),
                Language = new Language()
                {
                    Name = "Persian"
                },
                Authors = new List<Author>()
               {
                   new Author()
                   {
                       Name = "Margaret Mitchell"
                   },
                     new Author()
                   {
                       Name = "Test (Translator)"
                   },
               }
            };

            var book1 = new Book()
            {
                Title = "The Alchemist",
                ISBN = "43442424",
                Price = 60000,
                LastStock = new DateTime(),
                Language = new Language()
                {
                    Name = "Persian"
                },
                Authors = new List<Author>()
               {
                   new Author()
                   {
                       Name = "Paulo Coelho"
                   },
                     new Author()
                   {
                       Name = "Test (Translator)"
                   },
               }
            };

            // string connectionString = "mongodb://localhost:27017";
            // MongoClientSettings settings = MongoClientSettings.FromUrl(new MongoUrl(connectionString));
            //var client = new MongoClient(settings);
            var client = new MongoClient();
            var db = client.GetDatabase("publisher");
            var collection = db.GetCollection<Book>("books");

            var books = new List<Book> { book, book1 };
            await collection.InsertManyAsync(books);
        }
    }
}