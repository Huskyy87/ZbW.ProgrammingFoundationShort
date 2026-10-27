namespace ZbW.ProgrammingFoundationShort.Challenges.Module11.Aufgabe1_WortUmkehren;

public sealed class WortUmkehrenForm : Form
{
  private readonly TextBox TxtWord;
  private readonly Label LblIterative;
  private readonly Label LblRecursive;
  private readonly Label LblReflection;

  public WortUmkehrenForm()
  {
    Text = "Wort umkehren – Aufgabe 1";
    ClientSize = new Size(560, 240);

    Controls.Add(new Label { Location = new Point(12, 18), Size = new Size(80, 20), Text = "Wort:" });

    TxtWord = new TextBox { Location = new Point(95, 15), Size = new Size(180, 23), Text = "Algorithmus" };
    Button cmdReverse = new Button { Location = new Point(290, 13), Size = new Size(110, 28), Text = "Umkehren" };
    LblIterative = new Label { Location = new Point(12, 65), Size = new Size(520, 25) };
    LblRecursive = new Label { Location = new Point(12, 100), Size = new Size(520, 25) };
    LblReflection = new Label { Location = new Point(12, 140), Size = new Size(520, 70) };

    cmdReverse.Click += CmdReverse_Click;

    Controls.Add(TxtWord);
    Controls.Add(cmdReverse);
    Controls.Add(LblIterative);
    Controls.Add(LblRecursive);
    Controls.Add(LblReflection);
  }

  private void CmdReverse_Click(object sender, EventArgs e)
  {
    string word = TxtWord.Text;
    LblIterative.Text = $"Iterativ: {ReverseIterative(word)}";
    LblRecursive.Text = $"Rekursiv: {ReverseRecursive(word)}";
    LblReflection.Text = "Reflexion: Im Alltag ist die iterative Variante meist einfacher zu debuggen. " +
                         "Rekursion zeigt aber gut das Prinzip: ein Zeichen plus das kleinere Restproblem.";
  }

  public static string ReverseIterative(string text)
  {
    char[] result = new char[text.Length];

    for (int i = 0; i < text.Length; i++)
    {
      result[i] = text[text.Length - 1 - i];
    }

    return new string(result);
  }

  public static string ReverseRecursive(string text)
  {
    if (text.Length <= 1)
    {
      return text;
    }

    return ReverseRecursive(text[1..]) + text[0];
  }
}
