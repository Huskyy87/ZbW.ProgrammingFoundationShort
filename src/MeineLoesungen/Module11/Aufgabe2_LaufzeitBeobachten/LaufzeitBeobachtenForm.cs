namespace ZbW.ProgrammingFoundationShort.Challenges.Module11.Aufgabe2_LaufzeitBeobachten;

public sealed class LaufzeitBeobachtenForm : Form
{
  private readonly NumericUpDown NumTarget;
  private readonly ListBox LstOutput;
  private readonly int[] _numbers = Enumerable.Range(1, 63).Select(value => value * 2).ToArray();

  public LaufzeitBeobachtenForm()
  {
    Text = "Laufzeit beobachten – Aufgabe 2";
    ClientSize = new Size(620, 380);

    Controls.Add(new Label { Location = new Point(12, 18), Size = new Size(100, 20), Text = "Zielwert:" });

    NumTarget = new NumericUpDown { Location = new Point(115, 15), Size = new Size(90, 23), Minimum = 1, Maximum = 130, Value = 64 };
    Button cmdSearch = new Button { Location = new Point(220, 13), Size = new Size(130, 28), Text = "Vergleichen" };
    LstOutput = new ListBox { Location = new Point(12, 60), Size = new Size(580, 285) };

    cmdSearch.Click += CmdSearch_Click;

    Controls.Add(NumTarget);
    Controls.Add(cmdSearch);
    Controls.Add(LstOutput);
  }

  private void CmdSearch_Click(object sender, EventArgs e)
  {
    int target = (int)NumTarget.Value;
    SearchResult linear = LinearSearch(_numbers, target);
    SearchResult binary = BinarySearch(_numbers, target);

    LstOutput.Items.Clear();
    LstOutput.Items.Add($"Array: {_numbers.Length} sortierte Zahlen von {_numbers.First()} bis {_numbers.Last()}");
    LstOutput.Items.Add($"Gesucht: {target}");
    LstOutput.Items.Add($"Lineare Suche: Index {linear.Index}, Vergleiche {linear.Comparisons}");
    LstOutput.Items.Add($"Binäre Suche: Index {binary.Index}, Vergleiche {binary.Comparisons}");
    LstOutput.Items.Add("Interpretation: Binäre Suche halbiert den Suchraum und wächst deshalb langsamer im Aufwand.");
  }

  public static SearchResult LinearSearch(int[] sortedNumbers, int target)
  {
    int comparisons = 0;

    for (int i = 0; i < sortedNumbers.Length; i++)
    {
      comparisons++;
      if (sortedNumbers[i] == target)
      {
        return new SearchResult(i, comparisons);
      }
    }

    return new SearchResult(-1, comparisons);
  }

  public static SearchResult BinarySearch(int[] sortedNumbers, int target)
  {
    int left = 0;
    int right = sortedNumbers.Length - 1;
    int comparisons = 0;

    while (left <= right)
    {
      int middle = left + (right - left) / 2;
      comparisons++;

      if (sortedNumbers[middle] == target)
      {
        return new SearchResult(middle, comparisons);
      }

      if (sortedNumbers[middle] < target)
      {
        left = middle + 1;
      }
      else
      {
        right = middle - 1;
      }
    }

    return new SearchResult(-1, comparisons);
  }
}

public readonly record struct SearchResult(int Index, int Comparisons);
