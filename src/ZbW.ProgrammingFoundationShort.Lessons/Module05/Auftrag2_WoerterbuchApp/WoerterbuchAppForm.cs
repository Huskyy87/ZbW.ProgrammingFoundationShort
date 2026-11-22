namespace ZbW.ProgrammingFoundationShort.Lessons.Module05.Auftrag2_WoerterbuchApp;

// ============================================================
// AUFTRAG 2 – WoerterbuchApp (⭐⭐ Mittel | ~30 Min.)
//
// Übersetzungs-App mit Dictionary<string,string>.
//
// Anforderungen:
//   - 5 Wörter vorausfüllen (Deutsch → Englisch)
//   - TxtSuche + CmdNachschlagen: TryGetValue für Übersetzung
//   - TxtKeyNeu + TxtValueNeu + CmdHinzufuegen: ContainsKey-Prüfung
//   - LstEintraege: alle Einträge anzeigen
// ============================================================

public partial class WoerterbuchAppForm : Form
{
  // TODO 1: private Dictionary<string, string> _woerterbuch = new();
  private Dictionary<string, string> _worterbuch = new();

  public WoerterbuchAppForm()
  {
    InitializeComponent();
    // TODO 2: 5 Wörter vorab einfügen (z.B. Hund → Dog, Katze → Cat...)

    _worterbuch.Add("Hund", "Dog");
    _worterbuch.Add("Katze" , "Cat");
    _worterbuch.Add("Maus" , "Mouse");
    _worterbuch.Add("Haus" , "House");
    _worterbuch.Add("Baum" , "Tree");
    


    // TODO 3: AktualisiereListBox() aufrufen
    AktualisiereListBox();
  }

  private void CmdNachschlagen_Click(object sender, EventArgs e)
  {
    // TODO 4: TryGetValue für TxtSuche.Text
    //         Gefunden: LblErgebnis anzeigen
    //         Nicht gefunden: "Kein Eintrag für..."
    if (_worterbuch.TryGetValue(TxtSuche.Text, out string uebersetzung))
    {

      LblErgebnis.Text = uebersetzung;
    }
    else
    {
      LblErgebnis.Text = $"Kein Eintrag für {TxtSuche.Text} gefunden.";
    }
  }


  private void CmdHinzufuegen_Click(object sender, EventArgs e)
  {
    // TODO 5: Leere Felder prüfen
    if (TxtKeyNeu.Text.Trim().Length == 0 || TxtValueNeu.Text.Trim().Length == 0)
    {
      MessageBox.Show("Bitte beide Felder ausfüllen.");
      return;
    }

    string key = TxtKeyNeu.Text.Trim();
    string value = TxtValueNeu.Text.Trim();

    // TODO 6: ContainsKey-Prüfung → Überschreiben bestätigen

    if (_worterbuch.ContainsKey(key))
    {
      MessageBox.Show($"Das Wort {key} it beretis vorhanden.");
      return;
    }

    // TODO 7: _woerterbuch[key] = value;
    _worterbuch[key] = value;

    // TODO 8: AktualisiereListBox()
    AktualisiereListBox();
    TxtKeyNeu.Clear();
    TxtValueNeu.Clear();
    TxtKeyNeu.Focus();
  }

  private void AktualisiereListBox()
  {
    // TODO 9: LstEintraege befüllen aus _woerterbuch
    LstEintraege.Items.Clear();
    foreach (var pair in _worterbuch)
    {
      LstEintraege.Items.Add($"{pair.Key} -> {pair.Value}");
    }
  }
}
