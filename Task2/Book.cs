public class Book
{
    public string ISBN { get; private set; }
    public string Title { get; private set; }
    public string Author { get; private set; }
    public int Year { get; private set; }
    public bool IsAvailable { get; set; } = true;

    public Book(string isbn, string title, string author, int year)
    {
        ISBN = isbn;
        Title = title;
        Author = author;
        Year = year;
    }

    public void Borrow()
    {
        IsAvailable = false;
    }

    public void Return()
    {
        IsAvailable = true;
    }
}