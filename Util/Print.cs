namespace Util
{
    public class Print
    {
        public void PrintList<T>(IList<T> list)
        {
            if (list is IList<Book> books)
            {
                foreach (var book in books)
                {
                    Console.Write(book.Title + " By ");
                    foreach (var author in book.Authors)
                    {
                        Console.Write(author.Name);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}