namespace ZbW.ProgrammingFoundationShort.Challenges.Module10.Aufgabe3_DatenstrukturWahl;

/// <summary>
///   Aufgabe 3 (Optional) – Datenstruktur wählen (Transfer)
///   A: Rückgängig im Mini-Editor → Stack (das Zuletzt-Eingegebene kommt zuerst zurück)
///   B: Lagerbestand pro Artikelnummer → Dictionary (Zugriff über den Schlüssel)
///   C: Besucher in Ankunftsreihenfolge → List (Reihenfolge bleibt erhalten)
/// </summary>
public sealed class DatenstrukturWahlForm : Form
{
  private readonly Stack<string> _eingaben = new Stack<string>();
  private readonly Dictionary<string, int> _lager = new Dictionary<string, int>();
  private readonly List<string> _besucher = new List<string>();

  private readonly TextBox TxtWort;
  private readonly Label LblEditor;
  private readonly TextBox TxtArtikel;
  private readonly NumericUpDown NumMenge;
  private readonly Label LblLager;
  private readonly TextBox TxtBesucher;
  private readonly ListBox LstBesucher;

  public DatenstrukturWahlForm()
  {
    Text = "Datenstruktur wählen – Aufgabe 3";
    ClientSize = new Size(640, 420);

    // A: Mini-Editor mit Rückgängig (Stack)
    Controls.Add(new Label { Location = new Point(12, 12), Size = new Size(600, 20), Text = "A) Mini-Editor mit Rückgängig – Stack<string>" });
    TxtWort = new TextBox { Location = new Point(12, 37), Size = new Size(150, 23), Text = "Hallo" };
    Button cmdSchreiben = new Button { Location = new Point(170, 35), Size = new Size(100, 27), Text = "Schreiben" };
    Button cmdRueckgaengig = new Button { Location = new Point(275, 35), Size = new Size(100, 27), Text = "Rückgängig" };
    LblEditor = new Label { Location = new Point(12, 68), Size = new Size(600, 40) };

    // B: Lagerbestand (Dictionary)
    Controls.Add(new Label { Location = new Point(12, 120), Size = new Size(600, 20), Text = "B) Lagerbestand pro Artikelnummer – Dictionary<string, int>" });
    TxtArtikel = new TextBox { Location = new Point(12, 145), Size = new Size(150, 23), Text = "A-100" };
    NumMenge = new NumericUpDown { Location = new Point(170, 145), Size = new Size(70, 23), Minimum = 1, Maximum = 1000, Value = 5 };
    Button cmdEinlagern = new Button { Location = new Point(250, 143), Size = new Size(100, 27), Text = "Einlagern" };
    LblLager = new Label { Location = new Point(12, 176), Size = new Size(600, 40) };

    // C: Besucherliste (List)
    Controls.Add(new Label { Location = new Point(12, 228), Size = new Size(600, 20), Text = "C) Besucher in Ankunftsreihenfolge – List<string>" });
    TxtBesucher = new TextBox { Location = new Point(12, 253), Size = new Size(150, 23), Text = "Anna" };
    Button cmdAnkunft = new Button { Location = new Point(170, 251), Size = new Size(100, 27), Text = "Ankunft" };
    LstBesucher = new ListBox { Location = new Point(12, 285), Size = new Size(600, 115) };

    cmdSchreiben.Click += CmdSchreiben_Click;
    cmdRueckgaengig.Click += CmdRueckgaengig_Click;
    cmdEinlagern.Click += CmdEinlagern_Click;
    cmdAnkunft.Click += CmdAnkunft_Click;

    Controls.Add(TxtWort);
    Controls.Add(cmdSchreiben);
    Controls.Add(cmdRueckgaengig);
    Controls.Add(LblEditor);
    Controls.Add(TxtArtikel);
    Controls.Add(NumMenge);
    Controls.Add(cmdEinlagern);
    Controls.Add(LblLager);
    Controls.Add(TxtBesucher);
    Controls.Add(cmdAnkunft);
    Controls.Add(LstBesucher);
  }

  private void CmdSchreiben_Click(object sender, EventArgs e)
  {
    _eingaben.Push(TxtWort.Text);
    ZeigeEditor();
  }

  private void CmdRueckgaengig_Click(object sender, EventArgs e)
  {
    if (_eingaben.Count == 0)
    {
      LblEditor.Text = "Nichts mehr rückgängig zu machen.";
      return;
    }

    _eingaben.Pop(); // das zuletzt Geschriebene entfernen (LIFO)
    ZeigeEditor();
  }

  private void ZeigeEditor()
  {
    // Ein Stack wird von oben nach unten durchlaufen → für die Anzeige umdrehen
    string text = "";
    foreach (string wort in _eingaben)
    {
      text = wort + " " + text;
    }

    LblEditor.Text = $"Text: {text}";
  }

  private void CmdEinlagern_Click(object sender, EventArgs e)
  {
    string artikel = TxtArtikel.Text.Trim();
    int menge = (int)NumMenge.Value;

    if (_lager.ContainsKey(artikel))
    {
      _lager[artikel] += menge;
    }
    else
    {
      _lager[artikel] = menge;
    }

    LblLager.Text = $"{artikel}: {_lager[artikel]} Stück | {_lager.Count} verschiedene Artikel";
  }

  private void CmdAnkunft_Click(object sender, EventArgs e)
  {
    _besucher.Add(TxtBesucher.Text.Trim());

    LstBesucher.Items.Clear();
    for (int i = 0; i < _besucher.Count; i++)
    {
      LstBesucher.Items.Add($"{i + 1}. {_besucher[i]}");
    }
  }
}
