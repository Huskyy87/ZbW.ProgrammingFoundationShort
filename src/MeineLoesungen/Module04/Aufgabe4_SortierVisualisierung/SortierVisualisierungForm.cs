namespace ZbW.ProgrammingFoundationShort.Challenges.Module04.Aufgabe4_SortierVisualisierung;

/// <summary>
///   Aufgabe 4 – Sortier-Visualisierung (⭐⭐⭐⭐ Bonus)
///   BubbleSort mit Vergleichszähler und Vergleich zu Array.Sort.
/// </summary>
public partial class SortierVisualisierungForm : Form
{
  private int _vergleiche; // wird von BubbleSort gesetzt
  public SortierVisualisierungForm()
  {
    InitializeComponent();
  }

  private void CmdSortieren_Click(object sender, EventArgs e)
  {
    int[] zahlen;
    try
    {
      zahlen = InputToArray(TxtEingabe.Text);
    }
    catch (FormatException)
    {
      MessageBox.Show("Bitte kommagetrennte Zahlen eingeben (z.B. 5,3,8,1,9).",
        "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }
    catch (OverflowException)
    {
      MessageBox.Show("Eine Zahl ist zu gross oder zu klein für int (erlaubt: -2147483648 bis 2147483647).",
        "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    if (zahlen.Length < 2)
    {
      MessageBox.Show("Bitte mindestens 2 Zahlen eingeben.",
        "Zu wenig", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      return;
    }

    int[] bubbleSorted = BubbleSort(zahlen);
    int[] systemSorted = new int[zahlen.Length];
    Array.Copy(zahlen, systemSorted, zahlen.Length);
    Array.Sort(systemSorted);

    TxtErgebnis.Clear();
    TxtErgebnis.AppendText($"Original:    {string.Join(", ", zahlen)}\r\n");
    TxtErgebnis.AppendText($"BubbleSort:  {string.Join(", ", bubbleSorted)}\r\n");
    TxtErgebnis.AppendText($"Array.Sort:  {string.Join(", ", systemSorted)}\r\n");
    TxtErgebnis.AppendText(new string('-', 40) + "\r\n");
    TxtErgebnis.AppendText($"Vergleiche BubbleSort: {_vergleiche}\r\n");
    TxtErgebnis.AppendText($"BubbleSort sortiert korrekt: {IsSorted(bubbleSorted)}\r\n");
    TxtErgebnis.AppendText($"Array.Sort sortiert korrekt: {IsSorted(systemSorted)}\r\n");
  }

  private static int[] InputToArray(string text)
  {
    string[] teile = text.Split(',', StringSplitOptions.RemoveEmptyEntries);
    int[] zahlen = new int[teile.Length];
    for (int i = 0; i < teile.Length; i++)
    {
      zahlen[i] = int.Parse(teile[i].Trim());
    }

    return zahlen;
  }

  private int[] BubbleSort(int[] arr)
  {
    // Kopie anlegen, damit das Original unverändert bleibt
    int[] result = new int[arr.Length];
    Array.Copy(arr, result, arr.Length);
    _vergleiche = 0;

    for (int i = 0; i < result.Length - 1; i++)
    {
      for (int j = 0; j < result.Length - 1 - i; j++)
      {
        _vergleiche++;
        if (result[j] > result[j + 1])
        {
          int temp = result[j];
          result[j] = result[j + 1];
          result[j + 1] = temp;
        }
      }
    }

    return result;
  }

  private static bool IsSorted(int[] numbers)
  {
    for (int i = 0; i < numbers.Length - 1; i++)
    {
      if (numbers[i] > numbers[i + 1])
      {
        return false;
      }
    }

    return true;
  }
}