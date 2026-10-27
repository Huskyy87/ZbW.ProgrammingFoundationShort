namespace ZbW.ProgrammingFoundationShort.Challenges.Module06.Aufgabe4_Bibliothekssystem;

/// <summary>Bibliothek mit Buchverwaltung.</summary>
public class Library
{
  private readonly List<Book> _books = new();

  public int AvailableCount
  {
    get
    {
      int count = 0;
      foreach (Book book in _books)
      {
        if (book.IsAvailable)
        {
          count++;
        }
      }

      return count;
    }
  }

  /// <summary>Fügt ein Buch hinzu. Jede ISBN nur einmal – sonst wäre ein Exemplar nicht mehr ausleihbar.</summary>
  public bool AddBook(Book book)
  {
    if (string.IsNullOrEmpty(book.ISBN) || FindByIsbn(book.ISBN) != null)
    {
      return false;
    }

    _books.Add(book);
    return true;
  }

  public bool BorrowBook(string isbn)
  {
    Book book = FindByIsbn(isbn);
    if (book == null || !book.IsAvailable)
    {
      return false;
    }

    book.IsAvailable = false;
    return true;
  }

  public bool ReturnBook(string isbn)
  {
    Book book = FindByIsbn(isbn);
    if (book == null || book.IsAvailable)
    {
      return false;
    }

    book.IsAvailable = true;
    return true;
  }

  public List<Book> SearchByAuthor(string author)
  {
    List<Book> result = new List<Book>();
    foreach (Book book in _books)
    {
      if (book.Author.ToLower().Contains(author.ToLower()))
      {
        result.Add(book);
      }
    }

    return result;
  }

  public List<Book> GetAll()
  {
    return new List<Book>(_books);
  }

  private Book FindByIsbn(string isbn)
  {
    foreach (Book book in _books)
    {
      if (book.ISBN == isbn)
      {
        return book;
      }
    }

    return null;
  }
}
