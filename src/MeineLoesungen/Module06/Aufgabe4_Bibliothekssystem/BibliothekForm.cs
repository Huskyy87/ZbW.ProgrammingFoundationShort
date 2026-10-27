namespace ZbW.ProgrammingFoundationShort.Challenges.Module06.Aufgabe4_Bibliothekssystem;

/// <summary>
///   Aufgabe 4 – Bibliothekssystem (⭐⭐⭐ Schwer)
/// </summary>
public partial class BibliothekForm : Form
{
  private readonly Library _library = new();

  public BibliothekForm()
  {
    InitializeComponent();

    // Demo-Bücher vorab laden
    _library.AddBook(new Book("Clean Code", "Robert C. Martin", "978-0132350884"));
    _library.AddBook(new Book("The Pragmatic Programmer", "David Thomas", "978-0201616224"));
    _library.AddBook(new Book("Design Patterns", "Gang of Four", "978-0201633610"));

    AktualisiereListe();
  }

  private void CmdHinzufuegen_Click(object sender, EventArgs e)
  {
    Book book = new Book(TxtTitle.Text.Trim(), TxtAuthor.Text.Trim(), TxtISBN.Text.Trim());

    if (string.IsNullOrEmpty(book.Title) || string.IsNullOrEmpty(book.Author))
    {
      MessageBox.Show("Bitte Titel und Autor eingeben.",
        "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    if (!_library.AddBook(book))
    {
      MessageBox.Show("Bitte eine ISBN eingeben, die noch nicht vorhanden ist.",
        "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    AktualisiereListe();
    LblStatus.Text = $"Buch {book.ISBN} hinzugefügt. {Bestand()}";
    TxtTitle.Clear();
    TxtAuthor.Clear();
    TxtISBN.Clear();
  }

  private void CmdLeihen_Click(object sender, EventArgs e)
  {
    string isbn = TxtISBN.Text.Trim();
    bool erfolg = _library.BorrowBook(isbn);
    AktualisiereListe();
    // Meldung NACH dem Aktualisieren setzen, sonst wird sie sofort überschrieben
    LblStatus.Text = erfolg
      ? $"Buch {isbn} ausgeliehen. {Bestand()}"
      : $"Buch {isbn} nicht verfügbar oder nicht gefunden. {Bestand()}";
  }

  private void CmdZurueckgeben_Click(object sender, EventArgs e)
  {
    string isbn = TxtISBN.Text.Trim();
    bool erfolg = _library.ReturnBook(isbn);
    AktualisiereListe();
    LblStatus.Text = erfolg
      ? $"Buch {isbn} zurückgegeben. {Bestand()}"
      : $"Buch {isbn} war nicht ausgeliehen oder nicht gefunden. {Bestand()}";
  }

  private void CmdSuchen_Click(object sender, EventArgs e)
  {
    var result = _library.SearchByAuthor(TxtAuthor.Text.Trim());
    LstBuecher.Items.Clear();
    foreach (var book in result)
    {
      LstBuecher.Items.Add(book.ToString());
    }

    LblStatus.Text = $"{result.Count} Treffer für Autor \"{TxtAuthor.Text.Trim()}\"";
  }

  private void AktualisiereListe()
  {
    LstBuecher.Items.Clear();
    foreach (var book in _library.GetAll())
    {
      LstBuecher.Items.Add(book.ToString());
    }

    LblStatus.Text = Bestand();
  }

  private string Bestand()
  {
    return $"Bücher: {_library.GetAll().Count} gesamt, {_library.AvailableCount} verfügbar";
  }
}
