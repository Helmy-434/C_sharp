public class Library
{
    private List<Book> Books = new List<Book>();

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public void RemoveBook(Book book)
    {
        Books.Remove(book);
    }

    public List<Book> ViewAllBooks()
    {
        return Books;
    }
}