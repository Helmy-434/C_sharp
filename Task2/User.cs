public class User
{
    public string Name { get; private set; }
    public string LibraryCardNumber { get; private set; }
    public List<Book> BorrowedBooks { get; private set; } = new List<Book>();

    public User(string name, string librarycardnumber)
    {
        Name = name;
        LibraryCardNumber = librarycardnumber;
    }

    public void BorrowBook(Book book)
    {
        if (book.IsAvailable)
        {
            BorrowedBooks.Add(book);
            book.Borrow();
        }
        else
        {
            Console.WriteLine($"Sorry, '{book.Title}' is currently not available.");
        }
    }

    public void ReturnBook(Book book)
    {
        if (BorrowedBooks.Contains(book))
        {
            BorrowedBooks.Remove(book);
            book.Return();
        }
        else
        {
            Console.WriteLine($"You have not borrowed '{book.Title}'.");
        }
    }
}