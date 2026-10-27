namespace ZbW.ProgrammingFoundationShort.Challenges.Module07.Aufgabe2_EqualsImplementieren;

/// <summary>
///   Aufgabe 2 – Equals implementieren (⭐⭐ Mittel)
///   Vergleich zweier Produkte via == und .Equals().
/// </summary>
public partial class EqualsForm : Form
{
  public EqualsForm()
  {
    InitializeComponent();
  }

  private void CmdVergleichen_Click(object sender, EventArgs e)
  {
    if (!int.TryParse(TxtArtNr1.Text, out int artNr1) || !int.TryParse(TxtArtNr2.Text, out int artNr2))
    {
      LblErgebnis.Text = "Bitte Artikelnummern als ganze Zahlen eingeben.";
      return;
    }

    ProductVergleich p1 = new ProductVergleich
    {
      ArticleNumber = artNr1,
      Name = TxtName1.Text.Trim(),
      Price = decimal.TryParse(TxtPreis1.Text, out decimal pr1) ? pr1 : 0
    };

    ProductVergleich p2 = new ProductVergleich
    {
      ArticleNumber = artNr2,
      Name = TxtName2.Text.Trim(),
      Price = decimal.TryParse(TxtPreis2.Text, out decimal pr2) ? pr2 : 0
    };

    // == vergleicht bei Klassen die Referenzen (false bei zwei verschiedenen Objekten)
    bool refgleich = p1 == p2;
    // .Equals() vergleicht Artikelnummer
    bool wertgleich = p1.Equals(p2);

    LblErgebnis.Text = $"p1: {p1}\r\np2: {p2}\r\n\r\n" +
                       $"Referenz gleich (==): {refgleich}\r\n" +
                       $"Wert gleich (.Equals): {wertgleich}\r\n" +
                       $"→ Equals vergleicht nach Artikelnummer";
  }
}
