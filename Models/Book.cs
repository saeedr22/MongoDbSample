using MongoDB.Bson;

public class Book
{
    public ObjectId Id { get; set; }
    public string Title { get; set; }
    public string ISBN { get; set; }
    public int Price { get; set; }
    public List<Author> Authors { get; set; }
    public Language Language { get; set; }
    public DateTime LastStock { get; set; } = new DateTime();
}