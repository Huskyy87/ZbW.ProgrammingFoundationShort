namespace ZbW.ProgrammingFoundationShort.Challenges.Module12.Aufgabe2_KleineImplementation;

public sealed class KleineImplementationForm : Form
{
  private readonly TextBox TxtNames;
  private readonly TextBox TxtText;
  private readonly ListBox LstOutput;

  public KleineImplementationForm()
  {
    Text = "Kleine Implementation – Aufgabe 2";
    ClientSize = new Size(760, 420);

    Controls.Add(new Label { Location = new Point(12, 18), Size = new Size(110, 20), Text = "Namen:" });
    Controls.Add(new Label { Location = new Point(12, 55), Size = new Size(110, 20), Text = "Text:" });

    TxtNames = new TextBox { Location = new Point(125, 15), Size = new Size(430, 23), Text = "Anna, Ben, Anna, Clara, Ben" };
    TxtText = new TextBox { Location = new Point(125, 52), Size = new Size(430, 23), Text = "rot blau rot grün blau rot" };
    Button cmdRun = new Button { Location = new Point(575, 13), Size = new Size(120, 28), Text = "Auswerten" };
    LstOutput = new ListBox { Location = new Point(12, 100), Size = new Size(720, 270) };

    cmdRun.Click += CmdRun_Click;

    Controls.Add(TxtNames);
    Controls.Add(TxtText);
    Controls.Add(cmdRun);
    Controls.Add(LstOutput);
  }

  private void CmdRun_Click(object sender, EventArgs e)
  {
    string[] names = TxtNames.Text
      .Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

    List<string> uniqueNames = RemoveDuplicatesPreserveOrder(names);
    Dictionary<string, int> wordCounts = CountWords(TxtText.Text);

    LstOutput.Items.Clear();
    LstOutput.Items.Add($"Eindeutige Namen: {string.Join(", ", uniqueNames)}");
    LstOutput.Items.Add("Worthäufigkeiten:");

    foreach (KeyValuePair<string, int> pair in wordCounts)
    {
      LstOutput.Items.Add($"  {pair.Key}: {pair.Value}");
    }

    LstOutput.Items.Add("Warum nicht nur List<T>? List.Contains durchsucht nacheinander; HashSet/Dictionary passen besser zur Suche.");
  }

  public static List<string> RemoveDuplicatesPreserveOrder(IEnumerable<string> values)
  {
    HashSet<string> seen = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
    List<string> result = new List<string>();

    foreach (string value in values)
    {
      if (seen.Add(value))
      {
        result.Add(value);
      }
    }

    return result;
  }

  public static Dictionary<string, int> CountWords(string text)
  {
    Dictionary<string, int> counts = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
    char[] separators = { ' ', ',', '.', ';', ':', '!', '?' };

    foreach (string word in text.Split(separators, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries))
    {
      counts[word] = counts.GetValueOrDefault(word) + 1;
    }

    return counts;
  }
}
