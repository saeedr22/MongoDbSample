
using MongoDB.Bson;
using MongoDB.Driver;

namespace Services
{
    public class Update
    {
        public void UpdateOpr(FilterDefinition<Book> filter,UpdateDefinition<Book> update)
        {
            var client = new MongoClient();
            var db = client.GetDatabase("publisher");
            var collection = db.GetCollection<Book>("books");

            collection.UpdateManyAsync(filter, update);
        }
    }
}