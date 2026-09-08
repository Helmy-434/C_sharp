public class Librarian
{
    public string Name { get;  set; }
    public string LibraryCardNumber { get;  set; }

    public Librarian(string name, string libraryCardNumber)
    {
        Name = name;
        LibraryCardNumber = libraryCardNumber;
    }

    public void addBook(Book book, Library library)
    {
        library.AddBook(book);
    }

    public void removeBook(Book book, Library library)
    {
        library.RemoveBook(book);
    }

    public void viewAllBooks(Library library)
    {
        List<Book> books = library.ViewAllBooks();
        foreach (Book book in books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.Year}, Available: {book.IsAvailable}");
        }
    }
}