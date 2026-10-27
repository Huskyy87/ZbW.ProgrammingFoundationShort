namespace ZbW.ProgrammingFoundationShort.Challenges.Module06.Aufgabe4_Bibliothekssystem;

/// <summary>Buch mit Ausleihe-Status.</summary>
public class Book
{
  public Book(string title, string author, string isbn)
  {
    Title = title;
    Author = author;
    ISBN = isbn;
    IsAvailable = true;
  }

  public string Title { get; set; }
  public string Author { get; set; }
  public string ISBN { get; set; }
  public bool IsAvailable { get; set; }

  public override string ToString()
  {
    string status = IsAvailable ? "[verfügbar]" : "[ausgeliehen]";
    return $"{status} \"{Title}\" von {Author} (ISBN: {ISBN})";
  }
}
