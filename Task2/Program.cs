Library library = new Library();
Librarian librarian = new Librarian("John", "LIB001");

Book book1 = new Book("ISBN001", "C# Basics", "Jane Doe", 2020);
Book book2 = new Book("ISBN002", "Advanced C#", "John Smith", 2021);
Book book3 = new Book("ISBN003", "Web Development", "Alice Brown", 2022);

Console.WriteLine("--- Librarian adds books ---");
librarian.addBook(book1, library);
librarian.addBook(book2, library);
librarian.addBook(book3, library);

Console.WriteLine("\n--- All books in library ---");
librarian.viewAllBooks(library);

Console.WriteLine("\n--- User borrows a book ---");
User user = new User("Alice", "CARD001");
user.BorrowBook(book1);
Console.WriteLine($"User borrowed: {book1.Title}");

Console.WriteLine("\n--- All books after borrowing ---");
librarian.viewAllBooks(library);

Console.WriteLine("\n--- Librarian removes a book ---");
librarian.removeBook(book2, library);
Console.WriteLine($"Book removed: {book2.Title}");

Console.WriteLine("\n--- Final books in library ---");
librarian.viewAllBooks(library);
