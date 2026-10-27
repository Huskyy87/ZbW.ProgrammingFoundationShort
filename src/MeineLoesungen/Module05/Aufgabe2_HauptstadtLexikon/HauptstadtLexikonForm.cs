namespace ZbW.ProgrammingFoundationShort.Challenges.Module05.Aufgabe2_HauptstadtLexikon;

/// <summary>
///   Aufgabe 2 – Hauptstadt-Lexikon (⭐⭐ Mittel)
///   Transfer von Auftrag 2: Dictionary Land → Hauptstadt, Suche in beide Richtungen.
/// </summary>
public partial class HauptstadtLexikonForm : Form
{
  private readonly Dictionary<string, string> _hauptstaedte = new();

  public HauptstadtLexikonForm()
  {
    InitializeComponent();

    _hauptstaedte["Schweiz"] = "Bern";
    _hauptstaedte["Deutschland"] = "Berlin";
    _hauptstaedte["Österreich"] = "Wien";
    _hauptstaedte["Frankreich"] = "Paris";
    _hauptstaedte["Italien"] = "Rom";
  }

  private void CmdHauptstadt_Click(object sender, EventArgs e)
  {
    string land = TxtSuche.Text.Trim();

    // Schlüssel-Zugriff: schnell und direkt
    if (_hauptstaedte.TryGetValue(land, out string stadt))
    {
      LblErgebnis.Text = $"Die Hauptstadt von {land} ist {stadt}.";
    }
    else
    {
      LblErgebnis.Text = $"Land \"{land}\" nicht gefunden.";
    }
  }

  private void CmdLand_Click(object sender, EventArgs e)
  {
    string stadt = TxtSuche.Text.Trim();

    // Suche nach dem Wert: kein Schlüssel-Zugriff möglich → alle Einträge durchgehen
    foreach (KeyValuePair<string, string> eintrag in _hauptstaedte)
    {
      if (eintrag.Value == stadt)
      {
        LblErgebnis.Text = $"{stadt} ist die Hauptstadt von {eintrag.Key}.";
        return;
      }
    }

    LblErgebnis.Text = $"Stadt \"{stadt}\" nicht gefunden.";
  }

  private void CmdEintragHinzufuegen_Click(object sender, EventArgs e)
  {
    string land = TxtLandNeu.Text.Trim();
    string stadt = TxtStadtNeu.Text.Trim();

    if (string.IsNullOrEmpty(land) || string.IsNullOrEmpty(stadt))
    {
      MessageBox.Show("Bitte Land und Hauptstadt ausfüllen.",
        "Leere Felder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    if (_hauptstaedte.ContainsKey(land))
    {
      LblErgebnis.Text = $"{land} ist bereits erfasst ({_hauptstaedte[land]}).";
      return;
    }

    _hauptstaedte.Add(land, stadt);
    LblErgebnis.Text = $"Eintrag hinzugefügt: {land} → {stadt}";
    TxtLandNeu.Clear();
    TxtStadtNeu.Clear();
  }

  private void CmdAlleAnzeigen_Click(object sender, EventArgs e)
  {
    TxtAusgabe.Clear();
    foreach (KeyValuePair<string, string> eintrag in _hauptstaedte)
    {
      TxtAusgabe.AppendText($"{eintrag.Key,-15} → {eintrag.Value}" + Environment.NewLine);
    }

    TxtAusgabe.AppendText($"{_hauptstaedte.Count} Länder erfasst.");
  }
}
