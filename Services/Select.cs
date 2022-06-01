
using MongoDB.Bson;
using MongoDB.Driver;

namespace Services
{
    public class Select
    {
        public IList<Book> GetAll()
        {
            var client = new MongoClient();
            var db = client.GetDatabase("publisher");
            var collection = db.GetCollection<Book>("books");
            var filter = new BsonDocument();

            var list = collection.Find(filter).ToList();
            return list;
        }

         public IList<Book> Get(FilterDefinition<Book> filter,SortDefinition<Book> sort)
        {
            var client = new MongoClient();
            var db = client.GetDatabase("publisher");
            var collection = db.GetCollection<Book>("books");
            var list = collection.Find(filter).Sort(sort).ToList();
            return list;
        }
    }
}