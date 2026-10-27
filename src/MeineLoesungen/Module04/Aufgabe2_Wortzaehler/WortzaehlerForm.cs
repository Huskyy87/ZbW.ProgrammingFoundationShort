namespace ZbW.ProgrammingFoundationShort.Challenges.Module04.Aufgabe2_Wortzaehler;

/// <summary>
///   Aufgabe 2 – Wortzähler (⭐⭐ Mittel)
///   Analysiert einen Text mit mehreren Methoden.
/// </summary>
public partial class WortzaehlerForm : Form
{
  public WortzaehlerForm()
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

    string[] woerter = TextToWords(text);
    LblErgebnis.Text = $"Wörter: {CountWords(woerter)}\r\n" +
                       $"Zeichen (ohne Leerzeichen): {CountCharacters(text)}\r\n" +
                       $"Längstes Wort: \"{LongestWord(woerter)}\"";
  }

  private static string[] TextToWords(string text)
  {
    // Leerzeichen, Zeilenumbrüche als Trennzeichen
    return text.Split(new char[] { ' ', '\r', '\n', '\t' },
      StringSplitOptions.RemoveEmptyEntries);
  }

  private static int CountWords(string[] woerter)
  {
    return woerter.Length;
  }

  private static int CountCharacters(string text)
  {
    int count = 0;
    for (int i = 0; i < text.Length; i++)
    {
      if (text[i] != ' ' && text[i] != '\r' && text[i] != '\n' && text[i] != '\t')
      {
        count++;
      }
    }

    return count;
  }

  private static string LongestWord(string[] woerter)
  {
    if (woerter.Length == 0)
    {
      return "";
    }

    string longest = woerter[0];
    for (int i = 1; i < woerter.Length; i++)
    {
      if (woerter[i].Length > longest.Length)
      {
        longest = woerter[i];
      }
    }

    return longest;
  }
}
