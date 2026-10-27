namespace ZbW.ProgrammingFoundationShort.Challenges.Module05.Aufgabe1_Leseliste;

/// <summary>
///   Aufgabe 1 – Leseliste (⭐ Einfach)
///   Transfer von Auftrag 1: List&lt;string&gt; mit Duplikat-Prüfung, Sortieren und Zähler.
/// </summary>
public partial class LeselisteForm : Form
{
  private readonly List<string> _buecher = new();
  private int _gelesen = 0;

  public LeselisteForm()
  {
    InitializeComponent();
    AktualisiereAnzeige();
  }

  private void CmdHinzufuegen_Click(object sender, EventArgs e)
  {
    string titel = TxtTitel.Text.Trim();
    if (string.IsNullOrEmpty(titel))
    {
      MessageBox.Show("Bitte einen Buchtitel eingeben.",
        "Leere Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    // Duplikate ohne Rücksicht auf Gross-/Kleinschreibung erkennen
    foreach (string buch in _buecher)
    {
      if (buch.ToLower() == titel.ToLower())
      {
        MessageBox.Show($"\"{titel}\" steht bereits auf der Leseliste.",
          "Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }
    }

    _buecher.Add(titel);
    AktualisiereAnzeige();
    TxtTitel.Clear();
    TxtTitel.Focus();
  }

  private void CmdGelesen_Click(object sender, EventArgs e)
  {
    if (LstBuecher.SelectedIndex < 0)
    {
      MessageBox.Show("Bitte ein Buch auswählen.",
        "Keine Auswahl", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    _buecher.RemoveAt(LstBuecher.SelectedIndex);
    _gelesen++;
    AktualisiereAnzeige();
  }

  private void CmdSortieren_Click(object sender, EventArgs e)
  {
    _buecher.Sort(); // alphabetisch
    AktualisiereAnzeige();
  }

  private void CmdAlleLoeschen_Click(object sender, EventArgs e)
  {
    _buecher.Clear();
    AktualisiereAnzeige();
  }

  private void AktualisiereAnzeige()
  {
    LstBuecher.Items.Clear();
    foreach (string buch in _buecher)
    {
      LstBuecher.Items.Add(buch);
    }

    LblAnzahl.Text = $"Noch zu lesen: {_buecher.Count} | Bereits gelesen: {_gelesen}";
  }
}
