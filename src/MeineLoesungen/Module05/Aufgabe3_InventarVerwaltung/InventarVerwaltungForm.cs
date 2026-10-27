namespace ZbW.ProgrammingFoundationShort.Challenges.Module05.Aufgabe3_InventarVerwaltung;

/// <summary>
///   Aufgabe 3 – Inventar-Verwaltung (⭐⭐⭐ Anspruchsvoll)
///   Dictionary&lt;string,int&gt; für Artikel und Mengen.
/// </summary>
public partial class InventarVerwaltungForm : Form
{
  private const int MaxMenge = 100000; // Übungsbereich pro Artikel, verhindert int-Überlauf
  private readonly Dictionary<string, int> _inventar = new();

  public InventarVerwaltungForm()
  {
    InitializeComponent();

    _inventar["Äpfel"] = 50;
    _inventar["Bananen"] = 30;
    _inventar["Orangen"] = 20;
    _inventar["Trauben"] = 15;
    _inventar["Mangos"] = 10;
    _inventar["Kiwis"] = 0;

    AktualisiereListBox();
  }

  private void CmdHinzufuegen_Click(object sender, EventArgs e)
  {
    string artikel = TxtArtikel.Text.Trim();
    if (string.IsNullOrEmpty(artikel) || !int.TryParse(TxtMenge.Text, out int menge) || menge <= 0 || menge > MaxMenge)
    {
      MessageBox.Show($"Bitte gültigen Artikel und eine Menge von 1 bis {MaxMenge} eingeben.",
        "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    if (_inventar.ContainsKey(artikel))
    {
      if (_inventar[artikel] + menge > MaxMenge)
      {
        MessageBox.Show($"Höchstens {MaxMenge} Stück pro Artikel.",
          "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      _inventar[artikel] += menge;
    }
    else
    {
      _inventar[artikel] = menge;
    }

    AktualisiereListBox();
    TxtArtikel.Clear();
    TxtMenge.Clear();
  }

  private void CmdEntfernen_Click(object sender, EventArgs e)
  {
    string artikel = TxtArtikel.Text.Trim();
    if (string.IsNullOrEmpty(artikel) || !_inventar.ContainsKey(artikel))
    {
      MessageBox.Show($"Artikel \"{artikel}\" nicht gefunden.",
        "Nicht gefunden", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    if (!int.TryParse(TxtMenge.Text, out int menge) || menge <= 0)
    {
      MessageBox.Show("Bitte eine positive Menge zum Entfernen eingeben.",
        "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    _inventar[artikel] = Math.Max(0, _inventar[artikel] - menge);
    AktualisiereListBox();
    TxtArtikel.Clear();
    TxtMenge.Clear();
  }

  private void CmdSuchen_Click(object sender, EventArgs e)
  {
    string artikel = TxtArtikel.Text.Trim();
    if (_inventar.TryGetValue(artikel, out int menge))
    {
      LblGesamt.Text = $"Lagerbestand \"{artikel}\": {menge} Stück";
    }
    else
    {
      LblGesamt.Text = $"\"{artikel}\" nicht im Lager.";
    }
  }

  private void CmdAlleAnzeigen_Click(object sender, EventArgs e)
  {
    AktualisiereListBox();
  }

  private void AktualisiereListBox()
  {
    LstInventar.Items.Clear();
    int gesamt = 0;
    string ausverkauft = "";

    foreach (KeyValuePair<string, int> eintrag in _inventar)
    {
      string zeile = $"{eintrag.Key}: {eintrag.Value} Stück";
      if (eintrag.Value == 0)
      {
        zeile += " (ausverkauft)";
        ausverkauft += eintrag.Key + " ";
      }

      LstInventar.Items.Add(zeile);
      gesamt += eintrag.Value;
    }

    LblGesamt.Text = $"Gesamtbestand: {gesamt} Stück ({_inventar.Count} Artikel)";

    // Eine ListBox kann einzelne Zeilen nicht einfach einfärben → separates rotes Label
    LblAusverkauft.Text = ausverkauft == "" ? "" : "Ausverkauft: " + ausverkauft;
  }
}
