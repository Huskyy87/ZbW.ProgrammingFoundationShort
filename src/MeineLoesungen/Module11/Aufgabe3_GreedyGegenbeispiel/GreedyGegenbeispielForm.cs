namespace ZbW.ProgrammingFoundationShort.Challenges.Module11.Aufgabe3_GreedyGegenbeispiel;

public sealed class GreedyGegenbeispielForm : Form
{
  private readonly ListBox LstOutput;

  public GreedyGegenbeispielForm()
  {
    Text = "Greedy-Gegenbeispiel – Aufgabe 3";
    ClientSize = new Size(620, 340);

    Button cmdRun = new Button { Location = new Point(12, 12), Size = new Size(190, 30), Text = "Gegenbeispiel zeigen" };
    LstOutput = new ListBox { Location = new Point(12, 60), Size = new Size(580, 240) };

    cmdRun.Click += CmdRun_Click;

    Controls.Add(cmdRun);
    Controls.Add(LstOutput);
  }

  private void CmdRun_Click(object sender, EventArgs e)
  {
    int[] coins = { 4, 3, 1 };
    int amount = 6;
    List<int> greedy = MakeGreedyChange(amount, coins);
    List<int> optimal = MakeOptimalChange(amount, coins);

    LstOutput.Items.Clear();
    LstOutput.Items.Add($"Münzen: {string.Join(", ", coins)} | Betrag: {amount}");
    LstOutput.Items.Add($"Greedy: {string.Join(" + ", greedy)} = {greedy.Count} Münzen");
    LstOutput.Items.Add($"Optimal: {string.Join(" + ", optimal)} = {optimal.Count} Münzen");
    LstOutput.Items.Add("Warum scheitert Greedy? Die lokal beste Münze 4 blockiert hier die globale Lösung 3 + 3.");
  }

  public static List<int> MakeGreedyChange(int amount, int[] coins)
  {
    List<int> result = new List<int>();
    int rest = amount;

    foreach (int coin in coins.Where(coin => coin > 0).OrderByDescending(coin => coin))
    {
      while (rest >= coin)
      {
        result.Add(coin);
        rest -= coin;
      }
    }

    if (rest != 0)
    {
      throw new InvalidOperationException("Betrag kann mit diesen Münzen nicht exakt gebildet werden.");
    }

    return result;
  }

  public static List<int> MakeOptimalChange(int amount, int[] coins)
  {
    List<int>?[] best = new List<int>?[amount + 1];
    best[0] = new List<int>();

    for (int value = 1; value <= amount; value++)
    {
      foreach (int coin in coins.Where(coin => coin > 0))
      {
        if (value - coin < 0 || best[value - coin] is null)
        {
          continue;
        }

        List<int> candidate = new List<int>(best[value - coin]!) { coin };
        if (best[value] is null || candidate.Count < best[value]!.Count)
        {
          best[value] = candidate;
        }
      }
    }

    return best[amount] ?? throw new InvalidOperationException("Keine exakte Lösung gefunden.");
  }
}
