namespace ZbW.ProgrammingFoundationShort.Challenges.Module05.Aufgabe4_HaeufigkeitsAnalyse;

/// <summary>
///   Aufgabe 4 – Häufigkeits-Analyse (⭐⭐⭐⭐ Bonus)
///   Buchstabenhäufigkeit mit Dictionary, params-Formatierung und Vergleichswerten.
/// </summary>
public partial class HaeufigkeitsAnalyseForm : Form
{
  public HaeufigkeitsAnalyseForm()
  {
    InitializeComponent();
  }

  private void CmdAnalysieren_Click(object sender, EventArgs e)
  {
    string text = TxtEingabe.Text;
    if (string.IsNullOrWhiteSpace(text))
    {
      MessageBox.Show("Bitte einen Text eingeben.",
        "Kein Text", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    Dictionary<char, int> haeufigkeit = CountLetters(text);
    List<KeyValuePair<char, int>> sortiert = SortByFrequency(haeufigkeit);
    int anzahlTop = Math.Min(5, sortiert.Count);
    KeyValuePair<char, int>[] topFive = new KeyValuePair<char, int>[anzahlTop];
    for (int i = 0; i < anzahlTop; i++)
    {
      topFive[i] = sortiert[i];
    }

    TxtErgebnis.Clear();
    TxtErgebnis.AppendText($"Analysierter Text: {text.Length} Zeichen\r\n");
    TxtErgebnis.AppendText("Top-5 Buchstaben:\r\n");
    TxtErgebnis.AppendText(new string('-', 35) + "\r\n");
    TxtErgebnis.AppendText(FormatOutput(topFive));
    TxtErgebnis.AppendText("\r\nDeutsch häufig: e, n, i, s, r, a ...\r\n");
  }

  private static Dictionary<char, int> CountLetters(string text)
  {
    var result = new Dictionary<char, int>();
    foreach (char raw in text.ToLowerInvariant())
    {
      if (raw < 'a' || raw > 'z')
      {
        continue;
      }

      if (result.ContainsKey(raw))
      {
        result[raw]++;
      }
      else
      {
        result[raw] = 1;
      }
    }
    return result;
  }

  private static List<KeyValuePair<char, int>> SortByFrequency(Dictionary<char, int> dict)
  {
    List<KeyValuePair<char, int>> liste = new List<KeyValuePair<char, int>>(dict);

    // Bubble Sort (aus Block 04), absteigend nach Häufigkeit
    for (int i = 0; i < liste.Count - 1; i++)
    {
      for (int j = 0; j < liste.Count - 1 - i; j++)
      {
        if (liste[j].Value < liste[j + 1].Value)
        {
          KeyValuePair<char, int> temp = liste[j];
          liste[j] = liste[j + 1];
          liste[j + 1] = temp;
        }
      }
    }

    return liste;
  }

  private static string FormatOutput(params KeyValuePair<char, int>[] entries)
  {
    string ausgabe = "";

    foreach (KeyValuePair<char, int> entry in entries)
    {
      string balken = new string('█', Math.Min(entry.Value, 40));
      ausgabe += $"{entry.Key}: {balken} ({entry.Value})" + Environment.NewLine;
    }

    return ausgabe;
  }
}